public class Car
{
	public enum CarType
	{
		Sedan,
		SportsCar,
		Hatchback,
		Minivan,
		PickupTruck
	}
	private string brand;
	private string model;
	private int price;
	private int year;
	private CarType carType;
	private int rentalCost;
	private bool isRented;
	public Car(string brand, string model, int price, CarType carType, int year)
	{
		this.brand = brand;
		this.model = model;
		this.price = price;
		this.carType = carType;
		rentalCost = (int)((double)price * 0.003);
		isRented = false;
		this.year = year;
	}
	public string Brand { get => brand; set => brand = value; }
	public string Model { get => model; set => model = value; }
	public int Price { get => price; set => price = value; }
	public CarType ThisCarType { get => carType; set => carType = value; }
	public int RentalCost { get => rentalCost; set => rentalCost = value; }
	public bool IsRented { get => isRented; set => isRented = value; }
	public int Year { get => year; set => year = value; }
}