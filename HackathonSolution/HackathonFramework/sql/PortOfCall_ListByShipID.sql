SELECT PortOfCall.*, Port.Name FROM PortOfCall
INNER JOIN Port ON Port.PortID = PortOfCall.PortID
WHERE ShipID = @shipID
ORDER BY StopOrder ASC;