Console.Clear();

Console.Write("Enter number of X coordinate of the A line: ");
double firstCoordinateXA = int.Parse(Console.ReadLine());
Console.Write("Enter number of Y coordinate of the A line: ");
double secondCoordinateYA = int.Parse(Console.ReadLine());
Console.Write("Enter number of Z coordinate of the A line: ");
double thirdCoordinateZA = int.Parse(Console.ReadLine());

Console.Write("Enter number of X coordinate of the B line: ");
double firstCoordinateXB = int.Parse(Console.ReadLine());
Console.Write("Enter number of Y coordinate of the B line: ");
double secondCoordinateYB = int.Parse(Console.ReadLine());
Console.Write("Enter number of Z coordinate of the B line: ");
double thirdCoordinateZB = int.Parse(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow(firstCoordinateXB - firstCoordinateXA, 2) + Math.Pow(secondCoordinateYB - secondCoordinateYA, 2) + Math.Pow(thirdCoordinateZB - thirdCoordinateZA, 2));

Console.WriteLine($"Distance between two coordinates is {Math.Round(distance, 2)}");