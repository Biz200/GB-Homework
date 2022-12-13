Console.Clear();

int ThirdNumber(int numbers)
{
    Console.Write("Введите трехзначное число: ");
    numbers = int.Parse(Console.ReadLine());
    return numbers;
}

void Third (int numbers)
{
    if(numbers >= 100 || numbers <= -100)
    {
        while (numbers > 1000|| numbers < -1000 ){numbers = numbers/10;}
        int thirdnumb = numbers % 10;
        if(thirdnumb < 0 ){ thirdnumb =  thirdnumb * -1; }
        Console.WriteLine($"Третья цифра: {thirdnumb}");
    }
    else{Console.WriteLine("Третьей цифры нет");}
}

int numbers = 0;
int number = ThirdNumber(numbers);
Third(number);
