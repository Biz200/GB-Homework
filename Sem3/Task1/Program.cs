Console.Clear();

Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
int pal = number.Length;

if (pal == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine($"{number} - Палиндром");
    }
    else
    {
        Console.WriteLine($"{number} - не палиндром");
    }
}
else
{
    Console.WriteLine($"{number} - не является пятизначным");
}
