/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3*/
void FillArray(int[] arr)
{
    int length = arr.Length;//представляем длину массива
    int i = 0;//обнуляем счетчик
    while (i < length)//пока индекс меньше длины массива
    {
        arr[i] = new Random().Next(-5, 10);//заполняем элементы массива
        i++;//переходим к следующему элементу
    }
}
void PrintArray(int[] arr)
{
    int length = arr.Length;//задаем длину массива
    int i = 0;//обнуляем счетчик
    while (i < length)//пока индекс меньше длины массива
    {
        Console.Write(arr[i]);//выводим на экран элемент массива
        i++;//переходим к следующему элементу
    }
}
Console.WriteLine("ВВедите количество чисел");
int length = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[5];
FillArray(arr);
PrintArray(arr);
int count = 0;
for (int i = 0; i < 5; i++)
{
    


    if (arr[i] > 0)
    {
        count = count + 1;
        
        i++;
    }
    
}
Console.WriteLine($"Количество чисел больше 0 {count}");







