/ Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine ("Введите число a  ");
int a=Convert.ToInt32(Console.ReadLine());
int a1=a/100;
double a2=a1%10;
     if (a>1000)
    {
      if (a2>0)Console.WriteLine(a2%100); 
    }
    if (a<1000)
    {
        if (a2>0) Console.WriteLine(a%10);
        else Console.WriteLine("Третьей цифры нет");
    }
     
     
