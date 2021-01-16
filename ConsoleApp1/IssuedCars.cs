using System;

public class IssuedCar
{
	private Car car;
	private Client client;
	private DateTime dateOfIssue;
	private DateTime returnDate;

	public IssuedCar(Car car, Client client, DateTime dateOfIssue, DateTime returnDate)
	{
		this.car = car;
		this.client = client;
		this.dateOfIssue = dateOfIssue;
		this.returnDate = returnDate;
	}
	public Car Car { get => car; set => car = value; }
	public Client Client { get => client; set => client = value; }
	public DateTime DateOfIssue { get => dateOfIssue; set => dateOfIssue = value; }
	public DateTime ReturnDate { get => returnDate; set => returnDate = value; }
}