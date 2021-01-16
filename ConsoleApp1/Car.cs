﻿public class Car
{
	public enum CarType
	{
		Sedan,
		SportsCar,
		Hatchback,
		Minivan,
		PickupTruck
	}
	private static int next_id = 0;
	private int id;
	private string brand;
	private string model;
	private int price;
	private CarType carType;
	private int rentalCost;
	private bool isRented;

	public Car(string brand, string model, int price, CarType carType)
	{
		this.brand = brand;
		this.model = model;
		this.price = price;
		this.carType = carType;
		rentalCost = (int)((double)price * 0.003);
		isRented = false;
		id = next_id;
		next_id++;
	}
	public int Id { get => id; set => id = value; }
	public string Brand { get => brand; set => brand = value; }
	public string Model { get => model; set => model = value; }
	public int Price { get => price; set => price = value; }
	public CarType CarType1 { get => carType; set => carType = value; }
	public int RentalCost { get => rentalCost; set => rentalCost = value; }
	public bool IsRented { get => isRented; set => isRented = value; }
}