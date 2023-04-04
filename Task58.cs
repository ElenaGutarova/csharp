/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/
void PrintArray(int[,] array)//метод вывода на печать двумерного массива
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {

            Console.Write($"{array[i, j]} ");
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
void ResultArray(int[,] array1, int[,] array2, int[,] result)//метод произведения матриц
{
  for (int i = 0; i < result.GetLength(0); i++)
  {
    for (int j = 0; j < result.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < array1.GetLength(1); k++)
      {
        sum = sum+array1[i,k] * array2[k,j];
      }
      result[i,j] = sum;
    }
  }
}
int[,] array1=new int[2,2];
FillArray(array1);
PrintArray(array1);
int[,] array2=new int[2,2];
FillArray(array2);
PrintArray(array2);
int[,] result=new int[2,2];
ResultArray(array1,array2,result);
Console.WriteLine($"Произведение двух матриц:");
PrintArray(result);
