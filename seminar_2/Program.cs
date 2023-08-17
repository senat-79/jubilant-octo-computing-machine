// Задача 10

/* int Prompt (string message)
{
    System.Console.WriteLine (message);
    string value = Console.ReadLine ();
    int result = Convert.ToInt32 (value);
    return result;
}

int number = Prompt ("Введите трёхзначное число > ");
if (number < 100 || number >= 1000)
{
    Console.WriteLine ("Вы ввели не трёхзначное число, пожалуйста повторите ввод");
    return;
}
Console.WriteLine ($"Введённое число '{number}");
int secondRank = number / 10 % 10;
Console.WriteLine ($"Вторая цифра '{secondRank}'");
*/

// Задача 13

/*int Prompt (string message)
{
Console.Write (message);
    string value = Console.ReadLine ();
    int result = Convert.ToInt32 (value);
    return result;
}

int GetThirdRank (int number)
{
    while (number > 999)
    {
        number /= 10;
    }
    return number % 10;
}

bool ValidateNumber (int number)
{
    if (number < 100)
    {
        Console.WriteLine ("Третьей цифры нет");
        return false;
    }
    return true;
}

int number = Prompt ("Введите число > ");
if (ValidateNumber (number))
{
    Console.WriteLine (GetThirdRank (number));
}
*/

//Задача 15

/* int Prompt (string message)
{
Console.Write (message);
    string value = Console.ReadLine ();
    int result = Convert.ToInt32 (value);
    return result;
}

bool IsWeekend (int weekDay)
{
    if (weekDay > 5)
    {
        return true;
    }
    return false;
}

bool ValidateWeekday (int number)
{
    if (number > 0 && number <= 7)
    {
        return true;
    }
    Console.WriteLine ("Это не день недели!");
    return false;
}

int weekDay = Prompt ("Введите день недели >");
if (ValidateWeekday (weekDay))
{
    if (IsWeekend (weekDay))
    {
        Console.WriteLine ("Наконец-то выходной");
    }
    else
    {
        Console.WriteLine ("Придётся поработать");
    }
}
*/