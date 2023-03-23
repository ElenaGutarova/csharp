int c = 0;
int[] array = new int[12];
int result = 0;
while (c < 12)
{
    int x = new Random().Next(100, 1000);
    array[c] = x;
    Console.Write($" {array[c]}");
    c = c + 1;
}
c = 0;
while (c < 12)
{
    if (c % 2 == 0)
    {
        result = result + c;
    }
    c++;
}
Console.WriteLine("");
Console.Write($"Количество четных элементов = {result}");







