INSERT INTO Booking(
	ExcursionID,
	CabinID,
	Status,
	NumPassengers
) VALUES (
	@excursionID,
	@cabinID,
	@status,
	@numPassengers
);