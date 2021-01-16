using System;
using System.Collections.Generic;

public class Database
{
	private static int carId = 1;
	private static int usrId = 1;
	private static int rentId = 1;
	private Dictionary<int, Car> carDict;
	private Dictionary<int, Client> usrDict;
	private Dictionary<int, RentedCar> rentDict;
	private long income;
	public Database()
	{
		carDict = new Dictionary<int, Car>();
		usrDict = new Dictionary<int, Client>();
		rentDict = new Dictionary<int, RentedCar>();
	}
	public Dictionary<int, Client> UsrDict { get => usrDict; }
	public Dictionary<int, Car> CarDict { get => carDict; set => carDict = value; }
	public static int CarId { get => carId; set => carId = value; }
	public long Income { get => income; set => income = value; }

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
	public int addNewRent(RentedCar car)
	{
		rentDict.Add(rentId, car);
		rentId++;
		return rentId - 1;
	}
	public string rentCar(int carId, int usrId, DateTime dateTime)
	{
		if (carDict.ContainsKey(carId) && usrDict.ContainsKey(usrId))
		{
			if (!carDict[carId].IsRented && !usrDict[usrId].IsRented)
			{
				carDict[carId].IsRented = true;
				usrDict[usrId].IsRented = true;
				addNewRent(new RentedCar(carDict[carId], usrDict[usrId], DateTime.Today, dateTime));
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
	public void returnCar(Car car, Client usr)
	{
		car.IsRented = false;
		usr.IsRented = false;
	}
	public void printFreeCars()
	{
		foreach (KeyValuePair<int, Car> keyValue in carDict)
		{
			if (!keyValue.Value.IsRented)
			{
				Console.WriteLine(keyValue.Key + ". " + keyValue.Value.Brand + " " + keyValue.Value.Model + " Цена: " + keyValue.Value.Price + " Стоимость проката за час: " + keyValue.Value.RentalCost);
			}
		}
	}
	public void addIncome(long income)
	{
		this.income += income;
	}
	public RentedCar deleteRentedCar(Client usr)
	{
		RentedCar rent = null;
		int id = 0;
		foreach (KeyValuePair<int, RentedCar> keyValue in rentDict)
		{
			if (keyValue.Value.Client.Equals(usr))
			{
				id = keyValue.Key;
				rent = keyValue.Value;
				break;
			}
		}
		if (id != 0)
		{
			rentDict.Remove(id);
			returnCar(rent.Car, rent.Client);
		}
		return rent;
	}
}