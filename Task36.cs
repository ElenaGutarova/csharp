//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19

//[-4, -6, 89, 6] -> 0
int c = 0;
int[] array = new int[4];
int result = 0;
while (c < 4)
{
    int x = new Random().Next(10, 100);
    array[c] = x;
    Console.Write($" {array[c]}");
    c = c + 1;
}
c = 0;
while (c < 4)
{
    if (c / 2 == 0)
    {
        result = result + array[c];
    }
    c++;
}
Console.WriteLine("");
Console.Write($"Сумма элементов на нечетных позициях = {result}");
