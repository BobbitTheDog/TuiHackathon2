var cruiseID;
$(document).ready(function() {
	var updateon = setInterval(onpassupdate(),1000);
	var updatedis = setInterval(dispassupdate(),1000);
});

function onpassupdate(){
	
	$("#tblonboard td").remove();
	
	$.ajax({
        type: "GET",
        url: "http://localhost:80/passengeronboard?id=" + cruiseID,
        dataType: "json",
        cache: false,
        success: function(result) {
            $.each(result, function(index, cabinID, name) {
                $("#tblonboard").append($('<tr><td>'+cabinID + ' - ' + name + '</td></tr>'));
            });
        }
    });
};
function dispassupdate(){
	
	$("#tblonboard td").remove();
	
	$.ajax({
        type: "GET",
        url: "http://localhost:80/passengerdisembark?id=" + cruiseID,
        dataType: "json",
        cache: false,
        success: function(result) {
            $.each(result, function(index, cabinID, name) {
                $("#tbldisembark").append($('<tr><td>'+cabinID + ' - ' + name + '</td></tr>'));
            });
        }
    });
};