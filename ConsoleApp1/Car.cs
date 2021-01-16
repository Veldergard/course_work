public class Car
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
		PickupTruck,
		Crossover
	}

	private string brand;
	private string model;
	private int price;
	private int rentalCost;
	private CarType type;

	public Car(string brand, string model, int price, CarType type)
	{
		this.brand = brand;
		this.model = model;
		this.price = price;
		this.rentalCost = (int)((double)price * 0.003);
		this.type = type;
	}
}