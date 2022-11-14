Console.Clear();
Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine());

if (number % 2 == 0)
{
	Console.WriteLine("You chose correct number.");
}
else
{
	Console.WriteLine("Try another number!");
}