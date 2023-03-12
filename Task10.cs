// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine ("Введите число a  ");
int a=Convert.ToInt32(Console.ReadLine());
int a1=a/10;
int a2=a1%10;
Console.WriteLine(a2);

