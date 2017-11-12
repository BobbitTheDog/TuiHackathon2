var cruiseID = "150012";
var cabID;
var lat = [];
var lon = [];
var images = [];

$(document).ready(function() {
    $("form").on("submit", formSubmitHandler);
	$("#update").on("click", updateSubmitHandler);
	$("#cancel").on("click", cancelSubmitHandler);
    $("#cabinID").on("input", cabinID_oninput);

    $(window).on('hashchange', function() {
        if (location.hash.slice(1) === "book"||location.hash.slice(1) === "manage") {
            cabID = $("#cabinID").val();
			getExcursions(cabID);
			getPorts(cabID);
        }
		else{
			$("#excursionID").val("");
			$("#nopass").val("");
		}
		
		$("#cabinID").val("");
		$("#cabinID").trigger("input");
    });
	
	
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

function cabinID_oninput() {
    if ($("#cabinID").val() !== "") {
        $("#booklink").removeClass("disabled");
		$("#managelink").removeClass("disabled");
    }
    else {
        $("#booklink").addClass("disabled");
		$("#managelink").addClass("disabled");
    }
}

function getExcursions(cabinID) {
    console.log("GETTING FOR: " + cabinID);
    $.ajax({
        type: "GET",
        url: "http://localhost:56709/API/excursions/" + cruiseID,
        dataType: "json",
        cache: false,
        success: function(result) {
            $.each(result.availableExcursions, function(index, excursion) {
                $("#excursionID"&"exmanageID").append($('<option>', {
                    value: index,
                    text: excursion
                }));
            });
        }
		
    });
}

function getPorts(cabinID){
	$.ajax({
		type: "GET",
        url: "http://localhost:56709/API/ports/" + cruiseID,
        dataType: "json",
        cache: false,
        success: function(result) {
            $.each(result, function(index, lati, loni) {
                lat.push(lati),
				lon.push(loni)
            });
        }
	});
}

function formSubmitHandler(event) {
    event.preventDefault();
    var cabinID = $("#cabinID").val();
    var excursionID = $("#excursionID").val();
    var numPass = $("#nopass").val();

    // Returns successful data submission message when the entered information is stored in database.
    
    if (cabinID === '' || excursionID === '' || numPass === '')
    {
        alert("Please Fill All Fields");
    }
    else
    {
        // AJAX Code To Submit Form.
        $.ajax({
            type: "POST",
            url: "http://localhost:56709/API/bookings",
            data: {
				"cabinID": cabinID,
				"excursionID": excursionID,
				"numPass":numPass
			},
			datatype: "json",
            cache: false,
            success: function(result) {
                alert(result);
            }
        });
    }
    return false;
}

function updateSubmitHandler(event){
	event.preventDefault();
	var cabinID = $("#cabinID").val();
    var excursionID = $("#excursionID").val();
    var numPass = $("#nopass").val();
	
	// Returns successful data submission message when the entered information is stored in database.
    
    if (cabinID === '' || excursionID === '' || numPass === '')
    {
        alert("Please Fill All Fields");
    }
    else
    {
        // AJAX Code To Submit Form.
        $.ajax({
            type: "POST",
            url: "http://localhost:56709/API/updatebookings",
            data: {
				"cabinID": cabinID,
				"excursionID": excursionID,
				"numPass":numPass
			},
			datatype: "json",
            cache: false,
            success: function(result) {
                alert(result);
            }
        });
    }
    return false;
}

function cancelSubmitHandler(event){
    var excursionID = $("#excursionID").val();
	
	$.ajax({
		type: "POST",
		url: "http://localhost:56709/API/cancelbookings",
		data: "excursionID="+excursionID,
		success: function(result) {
                alert(result);
            }
	})
	
}
