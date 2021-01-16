using System;
using System.Collections.Generic;

public class Database
{
	private List<Car> carList;
	private List<Client> clientList;
	private List<IssuedCars> rentList;

	public Database()
	{
		carList = new List<Car>();
		clientList = new List<Client>();
		rentList = new List<IssuedCars>();
	}

	public void addNewCar(Car car)
	{
		carList.Add(car);
	}

	public void addNewClient(Client client)
	{
		clientList.Add(client);
	}

	public void addNewIssuedCar(IssuedCars car)
	{
		rentList.Add(car);
	}
}