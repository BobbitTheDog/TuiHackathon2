SELECT port1.portID
	,port2.portID
	,st_distance_sphere(port1.location, port2.location) distance
FROM port port1
INNER JOIN port port2 ON port1.SeaportID <> port2.SeaportID
	AND port2.SeaportID > port1.SeaportID
ORDER BY 1, 2;