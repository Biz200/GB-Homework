Console.Clear();

int Numbers (int number)
{
    Console.WriteLine("Введите цифру дня недели");
    number = int.Parse(Console.ReadLine());
    return number;
}

void Day(int number)
{
    if(number == 6 || number == 7){Console.WriteLine("Это выходной");}
    else{Console.WriteLine("Это не выходной");}
}

int number = 0;
int DayNumber = Numbers(number);
Day(DayNumber);
