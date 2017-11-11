var lat = [
	19.344704452, //Georgetown
	56.955674748 //RIGA
];

var lon = [
	-81.328000893, //Georgetown
	24.127686487 //RIGA
	
];

var images = [];

$(document).ready(function() {
	AmCharts.ready(function() {
	for (var i = 0; i < lat.length;i++) {
		AmCharts.loadFile("http://api.openweathermap.org/data/2.5/weather?lat=" + lat[i] + "&lon=" + lon[i] + "&units=metric&appid=5a8c4ac04c8d7c3d4e7491a255bdb60f", {}, function(json) {
			var data = AmCharts.parseJSON(json);
			var lines = [];
			var city = data;
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
    	});
	};
	
    var map = AmCharts.makeChart("chartdiv", {
      "type": "map",
      "theme": "light",
	  "projection": "miller",
      "dataProvider": {
		"getAreasFromMap": true,
        "map": "worldLow",
       // "zoomLevel": 5,
        //"zoomLongitude": 10,
        //"zoomLatitude": 50,
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
  });
});