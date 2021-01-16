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
		db.addNewCar(new Car("Tesla", "Cybertruck", 5900000, Car.CarType.PickupTruck));
		db.addNewCar(new Car("Tesla", "Model S", 9800000, Car.CarType.Sedan));
		db.addNewCar(new Car("Volkswagen", "Golf", 1765000, Car.CarType.Hatchback));
		db.addNewCar(new Car("Honda", "Odyssey", 2350000, Car.CarType.Minivan));

		db.addNewClient(new Client("Жмышенко", "Валерий", "Альбертович", "пер. Космонавтов, дом 23", "+7 (903) 903-09-67"));
		db.addNewClient(new Client("Соловьёв", "Фёдор", "Леонидович", "бульвар Ладыгина, дом 19", "+7 (948) 977-05-19"));
		db.addNewClient(new Client("Герасимов", "Евгений", "Богданович", "ул. Музейная, дом 69", "+7 (906) 408-78-33"));
		db.addNewClient(new Client("Белов", "Антон", "Николаевич", "ул. Кожевническая, дом 101", "+7 (921) 734-98-44"));
		db.addNewClient(new Client("Виноградов", "Трофим", "Андреевич", "ул. Новогодняя, дом 148", "+7 (900) 590-65-09"));
		db.addNewClient(new Client("Нестеров", "Марат", "Васильевич", "ул. Вересовская, дом 21", "+7 (982) 132-08-59"));
		db.addNewClient(new Client("Савина", "Ульяна", "Львовна", "ул. Задворная, дом 60", "+7 (956) 620-57-65"));

		Console.WriteLine(db.rentCar(8, 0));
	}
	static void Main(string[] args)
	{
		Database db = new Database();
		initDB(db);
	}
}
