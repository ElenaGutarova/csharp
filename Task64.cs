/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
int numb(int n)//метод перечисления всех натуральных чисел от 1 до n
{
    Console.Write($"{n} ");
    if ((n == 1) || (n == 0)) return 1; //условие выхода из функции
    return numb(n - 1);
}
numb(n);//вызов функции
