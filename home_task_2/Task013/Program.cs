
//Подскажите, как можно было уменьшить количество if'ов? Или направьте, в каком направлении смотреть. 

Console.Clear();
Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine());
if (number >= 100 && number <= 999)
{
	int thirdDigit = number % 10;
	Console.WriteLine($"Third digit of a number {number} is {thirdDigit}");
}
else if (number < 100)
{
	Console.WriteLine($"Third digit of a number {number} is missing.");
}
else if (number < 10000)
{
	int thirdDigit = (number / 10) % 10;
	Console.WriteLine($"Third digit of a number {number} is {thirdDigit}.");
}
else if (number < 100000)
{
	int thirdDigit = (number / 100) % 10;
	Console.WriteLine($"Third digit of a number {number} is {thirdDigit}.");
}
