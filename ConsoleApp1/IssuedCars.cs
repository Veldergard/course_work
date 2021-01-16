using System;

class IssuedCars
{
	private Car car;
	private Client client;
	private DateTime dateOfIssue;
	private DateTime returnDate;

	public IssuedCars(Car car, Client client, DateTime dateOfIssue, DateTime returnDate)
	{
		this.car = car;
		this.client = client;
		this.dateOfIssue = dateOfIssue;
		this.returnDate = returnDate;
	}
}