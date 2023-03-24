//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76
int c = 0;
double[] array = new double[] { 3, 7, 22, 2, 78 };
c=0;
while (c < 5)
{
    //int x = new Random().Next(10, 100);
    //array[c] = x;
    Console.Write($" {array[c]}");
    c++;
}
double min = array[0];
double max = array[0];
foreach (double i in array)  // Поиск максимального и минимального значения
    {
      if (min > i) min = i;
    }    
 
foreach (double i in array)  
    {
        if (max < i) max = i;
    }    
Console.WriteLine("");
Console.WriteLine($"\n Максимальный элемент: {max} Минимальный элемент: {min}");
Console.WriteLine($"Разница между максимальным и минимальным элементом: {max-min}");
