using System;
using System.Collections.Generic;

public class Database
{
	private static int carId = 1;
	private static int usrId = 1;
	private static int rentId = 1;
	private Dictionary<int, Car> carDict;
	private Dictionary<int, Client> usrDict;
	private Dictionary<int, IssuedCar> rentDict;
	private long money;
	public Database()
	{
		carDict = new Dictionary<int, Car>();
		usrDict = new Dictionary<int, Client>();
		rentDict = new Dictionary<int, IssuedCar>();
	}
	public Dictionary<int, Client> UsrDict { get => usrDict; }
	public int addNewCar(Car car)
	{
		carDict.Add(carId, car);
		carId++;
		return carId - 1;
	}
	public int addNewClient(Client client)
	{
		usrDict.Add(usrId, client);
		usrId++;
		return usrId - 1;
	}
	public int addNewRent(IssuedCar car)
	{
		rentDict.Add(rentId, car);
		rentId++;
		return rentId - 1;
	}
	public string rentCar(int carId, int usrId)
	{
		if (carDict.ContainsKey(carId) && usrDict.ContainsKey(usrId))
		{
			if (!carDict[carId].IsRented && !usrDict[usrId].IsRented)
			{
				carDict[carId].IsRented = true;
				usrDict[usrId].IsRented = true;
				addNewRent(new IssuedCar(carDict[carId], usrDict[usrId], DateTime.Now, DateTime.Now));
				usrDict[usrId].RentCount++;
				return "Клиент " + usrDict[usrId].Surname + " " + usrDict[usrId].Name + " взял в аренду " + carDict[carId].Brand + " " + carDict[carId].Model;
			}
			else if (carDict[carId].IsRented)
			{
				return "Машина " + carDict[carId].Brand + " " + carDict[carId].Model + " уже арендована.";
			}
			else
			{
				return "Клиент " + usrDict[usrId].Surname + " " + usrDict[usrId].Name + "уже арендовал машину";
			}
		}
		return "Вы выбрали несуществующую машину или клиента";
	}
	public void printUsers()
	{
		foreach (KeyValuePair<int, Client> keyValue in usrDict)
		{
			Console.WriteLine(keyValue.Key + ". " + keyValue.Value.Surname + " " + keyValue.Value.Name + " " + keyValue.Value.Patronymic);
		}
	}
}