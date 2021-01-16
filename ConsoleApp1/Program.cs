using System;

class Program
{
	static void Main(string[] args)
	{
		Client cl1 = new Client("Жмышенко", "Валерий", "Альбертович", "ул. Пушкина", "4899789");
		Client cl2 = new Client("Жмышенко", "Валерий", "Альбертович", "ул. Пушкина", "4899789");
		Client cl3 = new Client("Жмышенко", "Валерий", "Альбертович", "ул. Пушкина", "4899789");
		Console.WriteLine(cl1.Id);
		Console.WriteLine(cl2.Id);
		Console.WriteLine(cl3.Id);
	}
}
