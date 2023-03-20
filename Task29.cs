int Prompt(string message)
{
 Console.Write(message);
 string readInput = Console.ReadLine();
 int result=int.Parse(readInput);
 return result;
}
int [] Fillarray (int length, int min, int max)
{
    int [] array =new int [length];
    Random random=new Random();
    for (int i = 0; i < length; i++)
     {
       array [i]=new Random().Next (min, max+1);
     } 
    return array;
}
void Printarray (int [] array)    
{
    Console.Write ("[");
    for (int i = 0; i < array.Length-1; i++)
    {
        Console.Write ($"{array[i]},");
    }
    Console.Write ($"{array[array.Length-1]}");
    Console.Write ("]");
}
int length = Prompt ("Длина массива");
int Min = Prompt ("Начальное значение для диапазона случайного числа ");
int Max = Prompt ("Конечное значение для диапазона случайного числа ");
int [] array = Fillarray (length, Min, Max);
Printarray (array);
