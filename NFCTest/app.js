const location = "Onboard";

$(document).ready(function() {
	console.log("Page loaded.");
});

function PostLocation(passengerName){
	// use $.ajax here to do a POST to http://localhost:56709/api/passengers/passengerName, with data set to Location.
	// see https://api.jquery.com/jquery.post/
	$.ajax({
	  type: "POST",
	  url: url,
	  data: data,
	  success: successFunction,
	  dataType: "text"
	});
}