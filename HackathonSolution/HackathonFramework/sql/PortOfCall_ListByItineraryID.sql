SELECT PortOfCall.*, Name FROM PortOfCall
INNER JOIN Port ON PortOfCall.PortID = Port.PortID
WHERE ItineraryID = @itineraryID
ORDER BY StopOrder ASC;