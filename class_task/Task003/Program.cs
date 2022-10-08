/*
Напишите программу, которая будет выдавать
название дня недели по заданному номеру.
3 -> Среда
5 -> Пятница
*/

Console.Write("Enter weekday number: ");
int weekDayNumber = int.Parse(Console.ReadLine());

switch (weekDayNumber)
{
	case 1:
		Console.WriteLine("It is Monday!");
		break;
	case 2:
		Console.WriteLine("It is Tuesday!");
		break;
	case 3:
		Console.WriteLine("It is Wednesday!");
		break;
	case 4:
		Console.WriteLine("It is Thursday!");
		break;
	case 5:
		Console.WriteLine("It is Friyaaaaay!");
		break;
	case 6:
		Console.WriteLine("It is Saturday!");
		break;
	case 7:
		Console.WriteLine("It is Sunday!");
		break;
	default:
		Console.WriteLine("Wrong number.");
		break;
}

