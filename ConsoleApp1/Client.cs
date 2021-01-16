class Client
{
	private static int next_id = 0;
	private int id;
	private string surname;
	private string name;
	private string patronymic;
	private string address;
	private string telephoneNumb;

	public int Id
	{
		get { return id; }
	}

	public Client(string surname, string name, string patronymic, string address, string telephoneNumb)
	{
		this.surname = surname;
		this.name = name;
		this.patronymic = patronymic;
		this.address = address;
		this.telephoneNumb = telephoneNumb;
		id = next_id;
		next_id++;
	}
}