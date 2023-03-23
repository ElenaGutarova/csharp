//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76
int c = 0;
int[] array = new int[] { 3, 7, 22, 2, 78 };
//int result = 0;
while (c < 5)
{
    //int x = new Random().Next(10, 100);
    //array[c] = x;
    Console.Write($" {array[c]}");
    c++;
}
int Max = 0;
while (c>5)
{
    if (Max<array[c])
    {
        Max=array[c];
    }
    c++;
}
int Min = 0;
while (c>5)
{
    if (Min<array[c]  )
    {
        Min=array[c];
    }
    c++;
}
Console.WriteLine("");
Console.WriteLine($"Разница между максимальнм и минимальным элементом {Max-Min} ");
