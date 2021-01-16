using System;

class Car
{
	public enum CarType
	{
		Sedan,
		Coupe,
		SportsCar,
		StationWagon,
		Hatchback,
		Convertible,
		SportUtilityVehicle,
		Minivan,
		PickupTruck
	}

	private string brand;
	private int price;
	private int rentalCost;
	private CarType type;

	public Car(string brand, int price, int rentalCost, CarType type)
	{
		this.brand = brand;
		this.price = price;
		this.rentalCost = rentalCost;
		this.type = type;
	}
}

class Client
{
	private string surname;
	private string name;
	private string patronymic;
	private string address;
	private string telephoneNumb;

	public Client(string surname, string name, string patronymic, string address, string telephoneNumb)
	{
		this.surname = surname;
		this.name = name;
		this.patronymic = patronymic;
		this.address = address;
		this.telephoneNumb = telephoneNumb;
	}
}

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

class Program
{
	static void Main(string[] args)
	{
		Console.WriteLine("Hello World!");
	}
}
