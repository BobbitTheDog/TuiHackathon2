SELECT Excursion.* FROM Cruise
INNER JOIN PortOfCall ON PortOfCall.ItineraryID = Cruise.ItineraryID 
INNER JOIN Excursion ON Excursion.PortID = PortOfCall.PortID
WHERE CruiseID = @cruiseID;