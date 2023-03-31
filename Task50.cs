//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

//Например, задан массив:

//1 4 7 2

//5 9 2 3

//8 4 2 4

//17 -> такого числа в массиве нет

void PrintArray(int[,] array)//метод вывода на печать двумерного массива
{

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {

        Console.Write($"{array[i, j]}");
    }
    Console.WriteLine();
}

}
void FillArray(int[,] array)//метод заполнения массива
{
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
array[i, j] = new Random().Next(1, 10);
}
}
}
int[,] array = new int[3, 4];
FillArray(array);
PrintArray(array);
Console.WriteLine("Введите a ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b ");
int b = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < 3; i++)
{
for (int j = 0; j < 4; j++)
{
if ((a == i) && (b == j))
{
Console.WriteLine(array[i, j]);
break;
}
else
{
Console.WriteLine("Такого элемента нет");
break;
}
}
}
