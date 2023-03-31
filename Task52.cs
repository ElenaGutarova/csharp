/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/
void PrintArray(int[,] arr)//метод вывода на печать двумерного массива
{

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {

            Console.Write($" {arr[i, j]}"); ;
        }
        Console.WriteLine();
    }
}
void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }
    }
}
int[,] arr = new int[3, 4];
FillArray(arr);
PrintArray(arr);
double Sum = 0;
for (int j = 0; j < 4; j++)
{
    Sum = 0;

    for (int i = 0; i < 3; i++)
    {

        Sum = Sum + arr[i, j];

    }
    Console.WriteLine(Math.Round(Sum / 3, 1));
}



