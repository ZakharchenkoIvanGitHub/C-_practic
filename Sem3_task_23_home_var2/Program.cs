using System.Runtime.ConstrainedExecution;

//==========================================
//#23 Напишите программу, которая принимает на вход
//число(N) и выдаёт таблицу кубов чисел от 1 до N
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

//Возвращает двумерный массив с данными возведенными в степень
int[,] Calculate(int numberN, int pow)
{
    int[,] intArray = new int[2, numberN]; //создаем двумерный массив

    for (int i = 0; i < numberN; i++)
    {
        intArray[0, i] = i + 1; //Заносим данные в двумерный массив
        intArray[1, i] = (int)Math.Pow(i + 1, pow);
    }
    return intArray;
}

bool PrintLine(int x, int y)
{ //выводит разделительные линии
    try
    {
        Console.SetCursorPosition(x, y);
        Console.Write("|");
        Console.SetCursorPosition(x, y + 1);
        Console.Write("|");
    }
    catch
    {
        return true;
    }
    return false;
}

//Метод вывода результата из двумерного массива
void PrintResult(int[,] intArray)
{
    int x = 0;
    int y = 0;
    Console.Clear();
    if (PrintLine(x, y))
    {
        x = 0;
        y = y + 3;
    }

    for (int i = 0; i < intArray.Length / 2; i++)
    {
        try
        {
            Console.SetCursorPosition(x, y);
        }
        catch
        {
            x = 0;
            y = y + 3;
        }
        int lengthStrPow = intArray[1, i].ToString().Length; //вычисляем длину строки
        int lengthStr = intArray[0, i].ToString().Length; //вычисляем длину строки

        try
        {
            Console.SetCursorPosition((x + 2 + ((lengthStrPow - lengthStr) / 2)), y); //Выводим первую стоку
        }
        catch
        {
            x = 0;
            y = y + 3;
            Console.SetCursorPosition((x + 2 + ((lengthStrPow - lengthStr) / 2)), y);
        }

        Console.Write(intArray[0, i].ToString());

        Console.SetCursorPosition(x + 2, y + 1); //Выводим первую стоку
        Console.Write(intArray[1, i].ToString());

        x = x + lengthStrPow + 3;
        if (PrintLine(x, y))
        {
            x = 0;
            y = y + 3;
        }
    }

    Console.WriteLine();
    Console.WriteLine();
}

//Основная программа
Console.WriteLine("Введите число(N) и программа выдаст таблицу кубов чисел от 1 до N");
int num = ReadData("Введите N: ");

if (num != 0)
{
    PrintResult(Calculate(num, 3));
}
else
{
    ReadData("Ошибка! Необходимо ввести число");
}
;
