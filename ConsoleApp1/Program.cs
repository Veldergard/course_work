using System;

class Program
{
	static void initDB(Database db)
	{
		db.addNewCar(new Car("Toyota", "Camry", 1750000, Car.CarType.Sedan));
		db.addNewCar(new Car("Toyota", "Corolla", 1000000, Car.CarType.Sedan));
		db.addNewCar(new Car("Renault", "Logan", 675000, Car.CarType.Sedan));
		db.addNewCar(new Car("Lada", "Granta", 489000, Car.CarType.Sedan));
		db.addNewCar(new Car("Hyundai", "Solaris", 805000, Car.CarType.Sedan));
		db.addNewCar(new Car("Kia", "Rio", 834000, Car.CarType.Sedan));
		db.addNewCar(new Car("Audi", "R8", 11000000, Car.CarType.SportsCar));
		db.addNewCar(new Car("Hyundai", "Tucson", 1680000, Car.CarType.Sedan));
		db.addNewCar(new Car("Toyota", "Camry", 1750000, Car.CarType.Sedan));
		db.addNewCar(new Car("Toyota", "Camry", 1750000, Car.CarType.Sedan));

		db.addNewClient(new Client("Жмышенко", "Валерий", "Альбертович", "ул. Пушкина", "4899789"));
		db.addNewClient(new Client("Жмышенко", "Валерий", "Альбертович", "ул. Пушкина", "4899789"));
		db.addNewClient(new Client("Жмышенко", "Валерий", "Альбертович", "ул. Пушкина", "4899789"));
	}
	static void Main(string[] args)
	{
		Database db = new Database();
		initDB(db);
	}
}
