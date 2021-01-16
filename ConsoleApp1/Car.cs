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