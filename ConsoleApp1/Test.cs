class CarDB
{
	val listOfCars = listOf()
val listOfClients = listOf()
val listOfRents = listOf()
val listOfComplaints = listOf()

fun addClient()
	{

	}
	fun addCar()
	{

	}

	fun addRent(client: Client, car: Car)
	{
		// создается Rent
	}
	fun returnCar(car: Car, carHP: String)
	{
		//Ишешь в рент машину и проверяешь даты и состояние, если что не так заводишь по ИД клиента из рент Complain
	}
}

class Car(
val id: Int,
val name: String,
val price: Int,
val baseOrderPrice: Int,
val type: String,
//Новое поле для состояния машины
var carHP: String = "full"
)

class Client(
val id: Int,
val name: String,
val adress: String
//Не важно дальше
)

// В дб будет метод на проверку при возврате машины в котором надо будет валидировать дату возврата и состояние машины, если что не так ты просто заводишь Complain
class Rent(
val clientId: Int,
val carId: Int,
val date: LocalDate,
val date2: LocalDate
)

// Если что не так с машиной которую вернулди ты заводишь эту хрень.
class Complain(
val clientId: Int,
val desc: String
)
/**
* Суть в том что ты на прямую не будешь хранить в Client машины и жалобы что он взял
* Для этого у тебя есть классы. Так работают реляционные бд.
*/