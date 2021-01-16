public class Client
{
	private string surname;
	private string name;
	private string patronymic;
	private string address;
	private string phoneNumb;
	private bool isRented;
	private int rentCount;
	public Client(string surname, string name, string patronymic, string address, string telephoneNumb)
	{
		this.surname = surname;
		this.name = name;
		this.patronymic = patronymic;
		this.address = address;
		this.phoneNumb = telephoneNumb;
		isRented = false;
		rentCount = 0;
	}
	public string Surname { get => surname; set => surname = value; }
	public string Name { get => name; set => name = value; }
	public string Patronymic { get => patronymic; set => patronymic = value; }
	public string Address { get => address; set => address = value; }
	public string PhoneNumb { get => phoneNumb; set => phoneNumb = value; }
	public bool IsRented { get => isRented; set => isRented = value; }
	public int RentCount { get => rentCount; set => rentCount = value; }
}