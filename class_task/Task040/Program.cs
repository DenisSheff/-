/*
Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

AC <= AB + BC
*/

Console.Clear();
int firstNumber = GetNumber();
int secondtNumber = GetNumber();
int thirdtNumber = GetNumber();
CheckTriangle(firstNumber, secondtNumber, thirdtNumber);

int GetNumber()
{
	Console.WriteLine("Enter a number: ");
	int number = int.Parse(Console.ReadLine());
	return number;
}

void CheckTriangle(int firstSide, int secondSide, int thirdtSide)
{
	if (firstSide > 0 && secondSide > 0 && thirdtSide > 0)
	{
		if ((firstSide <= secondSide + thirdtSide) && (secondSide <= firstSide + thirdtSide) && (thirdtSide <= secondSide + firstSide))
		{
			Console.WriteLine("Inequation is correct.");
		}
		else
		{
			Console.WriteLine("Inequation is incorrect.");
		}
	}
	else
	{
		Console.WriteLine("One of the numbers is less than 0.");
	}
}


