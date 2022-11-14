/*
Напишите программу, которая
принимает на вход координаты двух точек и
находит расстояние между ними в 2D
пространстве.
A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21
*/

Console.Clear();
Console.Write("Enter number of X coordinate of the A line: ");
double firstCoordinateXA = int.Parse(Console.ReadLine());
Console.Write("Enter number of Y coordinate of the A line: ");
double secondCoordinateYA = int.Parse(Console.ReadLine());
Console.Write("Enter number of X coordinate of the B line: ");
double firstCoordinateXB = int.Parse(Console.ReadLine());
Console.Write("Enter number of Y coordinate of the B line: ");
double secondCoordinateYB = int.Parse(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow(firstCoordinateXB - firstCoordinateXA, 2) + Math.Pow(secondCoordinateYB - secondCoordinateYA, 2));

Console.WriteLine($"Distance between between two coordinates is {Math.Round(distance, 2)}");