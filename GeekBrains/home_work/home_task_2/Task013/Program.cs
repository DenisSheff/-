
//Подскажите, как можно было уменьшить количество if'ов? Или направьте, в каком направлении смотреть. 
/*
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
*/

Console.Clear();
Console.Write("Enter a number: ");
String number = Console.ReadLine();
//Приводим введеное число из типа String в тип int
int num = int.Parse(number);
//Находим длину строки для введенного числа
int index = number.Length;
/*
Если введенное число отрицательное, 
		то приводим его в положительный диапозон
		и 
		количество символов в строке уменьшаем на 1, чтобы убрать минус
*/
if (num < 0)
{
	num *= (-1);
	index--;
}
/*
Если количество символом меньше 3-х, сообщаем пользователю, что он ввел неправильное число
	и прерываем работу программы
*/
if (index < 3)
{
	Console.WriteLine($"There is no third digit in your {number}.");
}
//Для нахождения третьей цифры возводим в 10 степень уменьшенную на 3, чтобы исключить первые три числа
double temp = Math.Pow(10, index - 3);
index = (int)temp;
num = (num / index) % 10;
Console.WriteLine($"The third digit in your number {number} is {num}.");