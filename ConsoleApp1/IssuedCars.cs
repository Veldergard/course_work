using System;

public class RentedCar
{
	private Car car;
	private Client client;
	private DateTime dateOfRent;
	private DateTime returnDate;
	public RentedCar(Car car, Client client, DateTime dateOfIssue, DateTime returnDate)
	{
		this.car = car;
		this.client = client;
		this.dateOfRent = dateOfIssue;
		this.returnDate = returnDate;
	}
	public Car Car { get => car; set => car = value; }
	public Client Client { get => client; set => client = value; }
	public DateTime DateOfRent { get => dateOfRent; set => dateOfRent = value; }
	public DateTime ReturnDate { get => returnDate; set => returnDate = value; }
}