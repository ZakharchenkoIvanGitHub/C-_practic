//==========================================
//#28 Напишите программу, которая принимает на
//вход число N и выдаёт произведение чисел от 1 до N.
//==========================================

int ReadData(string greeting = "Введите данные")
//Получает строку заголовок
//Выдает введеное число, в случае ошибки выдает 0
{
    //Выводим сообщение
    Console.WriteLine(greeting);
    //считываем строку
    int.TryParse((Console.ReadLine() ?? "0"), out int number); // переводим в число
    return (number);
}

//выводит строку на печать
void PrintResult(string line)
{
    Console.WriteLine(line);
}

// Вариант с for
long CalculateFactorial(int num)
{
    long factorial = 1;
    for (int i = 1; i <= num; i++)
    {
        factorial = factorial * i;
    }
    return factorial;
}

//Вариант с while
long MultA(int numA)
{
    int i = 1;
    long prod = 1;
    while (i <= numA)
    {
        prod = prod * i;
        i++;
    }
    return prod;
}

//Рекурсия
long CalcData(int num)
{
    if (num == 1)
        return 1;
    return num * CalcData(num - 1);
}

int number = ReadData("Введите число: ");

long factorial = 0;

//Рекурсия
DateTime d3 = DateTime.Now;
factorial = CalcData(number);
Console.WriteLine(DateTime.Now - d3);
PrintResult("Факториал равен: " + factorial);

//Вариант с while
DateTime d2 = DateTime.Now;
factorial = MultA(number);
Console.WriteLine(DateTime.Now - d2);
PrintResult("Факториал равен: " + factorial);

// Вариант с for
DateTime d1 = DateTime.Now;
factorial = CalculateFactorial(number);
Console.WriteLine(DateTime.Now - d1);
PrintResult("Факториал равен: " + factorial);


