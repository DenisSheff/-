Console.Clear();
Console.Write("Enter three digit number: ");
int number = int.Parse(Console.ReadLine());
int secondDigit = (number / 10) % 10;

if ((number >= 100) && (number <= 999))
{
	Console.WriteLine($"Second digit of a number {number} is {secondDigit}.");
}
else if ((number >= -999) && (number <= -100))
{
	Console.WriteLine($"Second digit of a number {number} is {secondDigit}.");
}
else
{
	Console.WriteLine($"The number {number} is not fitted to the condition of the task.");
}
