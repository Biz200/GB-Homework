Console.Clear();

int Second(int numbers)
{
    Console.Write("Введите трехзначное число: ");
    numbers = int.Parse(Console.ReadLine());
    return numbers;
}

int numbers = 0;
int result = Second(numbers);
result = result / 10 % 10;

Console.WriteLine($"Вторая цифра: {result}");

