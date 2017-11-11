
var cities = [
  2643743, // London
  2950159, // Berlin
  2673730 // Stockholm
];

AmCharts.ready(function() {

  AmCharts.loadFile("http://api.openweathermap.org/data/2.5/group?id=" + cities.join(",") + "&units=metric&appid=5a8c4ac04c8d7c3d4e7491a255bdb60f", {}, function(json) {

    var data = AmCharts.parseJSON(json);
    var images = [];
	var lines = [];
    for (var i = 0; i < data.list.length; i++) {
      var city = data.list[i];
      var weather = city.weather.pop();
      images.push({
        "latitude": city.coord.lat,
        "longitude": city.coord.lon,
        "imageURL": "http://openweathermap.org/img/w/" + weather.icon + ".png",
        "width": 50,
        "height": 50,
        "label": city.name + ": " + Math.round(city.main.temp) + "C",
		"description": "Temp: " + city.main.temp + "C \n Humidity: " + city.main.humidity + "\n MaxTemp: " + city.main.temp_max + "C\n MinTemp: " + city.main.temp_min + "C"
      });
    }
	
	
	
	
	
    var map = AmCharts.makeChart("chartdiv", {
      "type": "map",
      "theme": "light",
	  "projection": "miller",
      "dataProvider": {
		"getAreasFromMap": true,
        "map": "worldLow",
        "zoomLevel": 5,
        "zoomLongitude": 10,
        "zoomLatitude": 50,
        "images": images,
      },
      "imagesSettings": {
        "labelRollOverColor": "#000",
        "labelPosition": "bottom"
      },
      "areasSettings": {
		"autoZoom": true,
		"selectedColor": "#CC0000",
        "alpha": 0.8
      },
	  "smallMap": {}
    });
  })

});