// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53
Console.WriteLine("Введите A    ");
double x1=Convert.ToDouble(Console.ReadLine());
double Y1=Convert.ToDouble(Console.ReadLine());
double Z1=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите B    ");
double x2=Convert.ToDouble(Console.ReadLine());
double Y2=Convert.ToDouble(Console.ReadLine());
double Z2=Convert.ToDouble(Console.ReadLine());
Console.WriteLine (Math.Sqrt((Math.Pow(x2-x1,2))+(Math.Pow(Y2-Y1,2))+(Math.Pow(Z2-Z1,2))));
