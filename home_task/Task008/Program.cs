/*## Task 8
*Напишите программу, которая на вход
принимает число (N), а на выходе показывает все чётные
числа от 1 до N.*

### Example: 

5 -> 2, 4

8 -> 2, 4, 6, 8
*/

Console.Clear();
Console.Write("Enter your number: ");
int number = int.Parse(Console.ReadLine());
int i = 1;

while (true)
{
	while (i <= number)
	{
		if (i % 2 == 0)
		{
			Console.WriteLine(i + ", ");
		}
		i++;
	}
	if (number == 0)
	{
		Console.WriteLine("Enter whole number");
	}
	if (number == 1)
	{
		Console.WriteLine("Enter another number");
	}
	break;
}

