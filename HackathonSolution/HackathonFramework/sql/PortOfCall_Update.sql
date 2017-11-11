UPDATE PortOfCall
SET StopOrder = @stopOrder
WHERE ShipID = @shipID
	AND PortID = @portID;