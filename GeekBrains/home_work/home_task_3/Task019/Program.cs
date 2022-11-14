/*
## Task 19
*Напишите программу, которая принимает на
вход пятизначное число и проверяет, является ли оно
палиндромом.*

### Example: 

14212 -> нет

23432 -> да

12821 -> да
*/
/*
Console.Clear();
Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine());

int reverseNumber = int.Parse(Array.Reverse(number));
int oppositeNumber = Convert.ToInt32(reverseNumber);

if (number == reverseNumber)
{
	Console.WriteLine("The number you entered is palindrome.");
}
else
{
	Console.WriteLine("Try again.");
}*/

Console.Clear();
Console.Write("Enter a number: ");
string number = Console.ReadLine();

void CheckingNumber(string number)
{
	if (number[0] == number[4] || number[1] == number[3])
	{
		Console.WriteLine($"Your number {number} is palidrom.");
	}
	else Console.WriteLine("Try again.");
}

if (number.Length == 5)
{
	CheckingNumber(number);
}
else Console.WriteLine("Choose correct number.");