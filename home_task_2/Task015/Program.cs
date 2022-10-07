/*
## Task 15
*Напишите программу, которая принимает на
вход цифру, обозначающую день недели, и проверяет,
является ли этот день выходным.*

### Example: 

6 -> да

7 -> да

1 -> нет

*/
Console.Clear();
Console.Write("Enter weekday number: ");
int weekDayNumber = int.Parse(Console.ReadLine());

switch (weekDayNumber)
{
	case 1:
		Console.WriteLine("It is Monday!");
		Console.WriteLine("Go to job:(((!");
		break;
	case 2:
		Console.WriteLine("It is Tuesday!");
		Console.WriteLine("Go to job:(((!");
		break;
	case 3:
		Console.WriteLine("It is Wednesday!");
		Console.WriteLine("Go to job:(((!");
		break;
	case 4:
		Console.WriteLine("It is Thursday!");
		Console.WriteLine("Go to job:(((!");
		break;
	case 5:
		Console.WriteLine("It is Friyaaaaay! But...");
		Console.WriteLine("Go to job:(((!");
		break;
	case 6:
		Console.WriteLine("It is Saturday! Weekend is just started!");
		break;
	case 7:
		Console.WriteLine("It is Sunday! Weekedn is almost over but you still have time!");
		break;
	default:
		Console.WriteLine("Wrong number.");
		break;
}

