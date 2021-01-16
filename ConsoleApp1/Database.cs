using System;
using System.Collections.Generic;

public class Database
{
	private static int carId = 0;
	private static int usrId = 0;
	private static int rentId = 0;
	private Dictionary<int, Car> carDict;
	private Dictionary<int, Client> usrDict;
	private Dictionary<int, IssuedCar> rentDict;
	public Database()
	{
		carDict = new Dictionary<int, Car>();
		usrDict = new Dictionary<int, Client>();
		rentDict = new Dictionary<int, IssuedCar>();
	}
	public void addNewCar(Car car)
	{
		carDict.Add(carId, car);
		carId++;
	}
	public void addNewClient(Client client)
	{
		usrDict.Add(usrId, client);
		usrId++;
	}
	public void addNewIssuedCar(IssuedCar car)
	{
		rentDict.Add(rentId, car);
		rentId++;
	}
	public string rentCar(int carId, int usrId)
	{
		if (carDict.ContainsKey(carId) && usrDict.ContainsKey(usrId))
		{
			if (!carDict[carId].IsRented && !usrDict[usrId].IsRented)
			{
				carDict[carId].IsRented = true;
				usrDict[usrId].IsRented = true;
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
}