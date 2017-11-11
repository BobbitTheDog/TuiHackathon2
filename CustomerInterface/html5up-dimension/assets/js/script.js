var cabID;
var cruiseID;
$(document).ready(function() {
    $("form").on("submit", formSubmitHandler);
	$("#update").on("click", updateSubmitHandler);
	$("#cancel").on("click", cancelSubmitHandler);
    $("#cabinID").on("input", cabinID_oninput);

    $(window).on('hashchange', function() {
        if (location.hash.slice(1) === "book"||location.hash.slice(1) === "manage") {
            cabID = $("#cabinID").val();
			getExcursions(cabID);
        }
		else{
			$("#excursionID").val("");
			$("#nopass").val("");
		}
		
		$("#cabinID").val("");
		$("#cabinID").trigger("input");
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
        url: "http://localhost:80/excursions?id=" + cabinID,
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
		/*
		* {
			cruiseID: "",
			bookings: [{excursion objects}]
			availableExcursions: [{excursion objects}]
		
		* }
		*
		*/
    });
}

function formSubmitHandler(event) {
    event.preventDefault();
    var cabinID = $("#cabinID").val();
    var excursionID = $("#excursionID").val();
    var numPass = $("#nopass").val();

    // Returns successful data submission message when the entered information is stored in database.
    var dataString = 'cabinID=' + cabinID + '&excursionID=' + excursionID + '&numPass=' + numPass;
    if (cabinID === '' || excursionID === '' || numPass === '')
    {
        alert("Please Fill All Fields");
    }
    else
    {
        // AJAX Code To Submit Form.
        $.ajax({
            type: "POST",
            url: "http://localhost:80/book",
            data: dataString,
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
    var dataString = 'cabinID=' + cabinID + '&excursionID=' + excursionID + '&numPass=' + numPass;
    if (cabinID === '' || excursionID === '' || numPass === '')
    {
        alert("Please Fill All Fields");
    }
    else
    {
        // AJAX Code To Submit Form.
        $.ajax({
            type: "POST",
            url: "http://localhost:80/book",
            data: dataString,
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
		url: "http://localhost:80/cancel",
		data: "excursionID="+excursionID,
		success: function(result) {
                alert(result);
            }
	})
	
}