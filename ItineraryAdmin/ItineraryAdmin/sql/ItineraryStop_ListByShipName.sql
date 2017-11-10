SELECT ItineraryStop.*, Name FROM ItineraryStop
INNER JOIN Seaport ON ItineraryStop.SeaportID = Seaport.SeaportID
WHERE ShipID = (SELECT ShipID FROM CruiseShip WHERE Name = @ShipName)
ORDER BY StopOrder ASC;