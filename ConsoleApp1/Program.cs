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

		Console.WriteLine(db.rentCar(9, 1));
	}
	public static void returnCar(Database db, int usrId)
	{

	}
	public static void takeCar(Database db, int usrId)
	{
		while (true)
		{

		}
	}
	public static void runRentMenu(Database db, int usrId)
	{
		Console.Clear();
		string str;
		while (true)
		{
			Console.Clear();
			Console.WriteLine("Выберите желаемое действие:\n1.Взять машину в аренду\n2.Вернуть машину\n0.Выйти");
			str = Console.ReadLine();
			if (str.Equals("0"))
			{
				break;
			}
			else if (str.Equals("1"))
			{
				takeCar(db, usrId);
			}
			else if (str.Equals("2"))
			{
				returnCar(db, usrId);
			}
			else
			{
				Console.WriteLine("Введена несуществующая опция");
			}
		}
	}
	public static void login(Database db, int usrId)
	{
		if (usrId == -1)
		{
			Console.Clear();
			Console.WriteLine("Выберите своего пользователя:");
			db.printUsers();
			Console.WriteLine("0. Вернуться к началу");
			while (!db.UsrDict.ContainsKey(usrId))
			{
				try
				{
					usrId = Convert.ToInt32(Console.ReadLine());
				}
				catch (Exception)
				{
					Console.WriteLine("Некорректно введена строка или пользователя не существует");
					usrId = -1;
					continue;
				}
				if (usrId == 0)
				{
					return;
				}
			}
		}
		runRentMenu(db, usrId);
	}
	public static void register(Database db)
	{
		Console.Clear();
		Console.Write("Введите свою фамилию: ");
		string surname = Console.ReadLine();
		Console.Write("Введите своё имя: ");
		string name = Console.ReadLine();
		Console.Write("Введите своё отчество: ");
		string patronymic = Console.ReadLine();
		Console.Write("Введите свой адрес: ");
		string address = Console.ReadLine();
		Console.Write("Введите свой номер телефона: ");
		string phoneNumb = Console.ReadLine();
		Client client = new Client(surname, name, patronymic, address, phoneNumb);
		int usrId = db.addNewClient(client);
		login(db, usrId);
	}
	public static void run(Database db)
	{
		string str;
		while (true)
		{
			Console.Clear();
			Console.WriteLine("Выберите желаемое действие:\n1.Создать аккаунт клиента\n2.Войти в аккаунт клиента\n0.Выйти");
			str = Console.ReadLine();
			if (str.Equals("0"))
			{
				break;
			}
			else if (str.Equals("1"))
			{
				register(db);
			}
			else if (str.Equals("2"))
			{
				login(db, -1);
			}
			else
			{
				Console.WriteLine("Введена несуществующая опция");
			}
		}
	}
	static void Main(string[] args)
	{
		Database db = new Database();
		initDB(db);
		run(db);
	}
}
