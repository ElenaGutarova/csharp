// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

//3, 5 -> 243 (3⁵)

//2, 4 -> 16
int Prompt(string message)
{
 Console.Write(message);
 string readInput = Console.ReadLine();
 int result=int.Parse(readInput);
 return result;
}
int Power (int PowerBase, int exponent)
{
    int Power=1;
    for (int i = 0; i < exponent; i++)
    {
        Power*=PowerBase;
    }
    return Power;
}
bool ValidateExponent (int exponent)
{
    if (exponent<0)
    {
        Console.WriteLine ("Показатель не должен быть меньше нуля");
        return false;
    }
    return true;
}
int PowerBase = Prompt ("Введите основание ");
int exponent = Prompt ("Введите показатель ");
if (ValidateExponent (exponent))
{
    Console.WriteLine ($"Число {PowerBase} в степени {exponent} равно {Power (PowerBase,exponent)}");
    
}
