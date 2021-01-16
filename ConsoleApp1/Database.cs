using System.Collections.Generic;

public class Database
{
	private List<Car> carList;
	private List<Client> clientList;
	private List<IssuedCar> rentList;

	public Database()
	{
		carList = new List<Car>();
		clientList = new List<Client>();
		rentList = new List<IssuedCar>();
	}

	public void addNewCar(Car car)
	{
		carList.Add(car);
	}

	public void addNewClient(Client client)
	{
		clientList.Add(client);
	}

	public void addNewIssuedCar(IssuedCar car)
	{
		rentList.Add(car);
	}

	public string rentCar(int userId, int carId)
	{
		Car car = carList.Find(x => x.getId() == carId);
		Client user = clientList.Find(x => x.getId() == userId);
		if (!car.getRent() || !user.getRent())
		{
			return "Машина" + car.get;
		}
		return 0;
	}
}