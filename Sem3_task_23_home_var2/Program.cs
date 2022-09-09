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

void PrintLine(int x)
{ //выводит разделительные линии
    Console.SetCursorPosition(x, 0);
    Console.Write("|");
    Console.SetCursorPosition(x, 1);
    Console.Write("|");
}

//Метод вывода результата из двумерного массива
void PrintResult(int[,] intArray)
{
    int x = 0;
    Console.Clear();
    PrintLine(x);

    for (int i = 0; i < intArray.Length / 2; i++)
    {
        Console.SetCursorPosition(x, 0);
        int lengthStrPow = intArray[1, i].ToString().Length; //вычисляем длину строки
        int lengthStr = intArray[0, i].ToString().Length; //вычисляем длину строки

        Console.SetCursorPosition((x + 2 + ((lengthStrPow - lengthStr) / 2)), 0); //Выводим первую стоку
        Console.Write(intArray[0, i].ToString());

        Console.SetCursorPosition(x + 2, 1); //Выводим первую стоку
        Console.Write(intArray[1, i].ToString());

        x = x + lengthStrPow + 3;
        PrintLine(x);
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
