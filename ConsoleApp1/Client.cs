public class Client
{
	private static int next_id = 0;
	private int id;
	private string surname;
	private string name;
	private string patronymic;
	private string address;
	private string telephoneNumb;
	private bool isRented;
	public Client(string surname, string name, string patronymic, string address, string telephoneNumb)
	{
		this.surname = surname;
		this.name = name;
		this.patronymic = patronymic;
		this.address = address;
		this.telephoneNumb = telephoneNumb;
		isRented = false;
		id = next_id;
		next_id++;
	}

	public int Id { get => id; set => id = value; }
	public string Surname { get => surname; set => surname = value; }
	public string Name { get => name; set => name = value; }
	public string Patronymic { get => patronymic; set => patronymic = value; }
	public string Address { get => address; set => address = value; }
	public string TelephoneNumb { get => telephoneNumb; set => telephoneNumb = value; }
	public bool IsRented { get => isRented; set => isRented = value; }
}