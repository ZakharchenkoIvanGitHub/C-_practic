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

//Возвращает строку с заданным количеством символов
string GetMultiChar(char symbol, int multiplier)
{
    return new(symbol, multiplier);
}
;

//Возвращает двумерный массив с данными возведенными в степень
string[,] Calculate(int numberN, int pow)
{
    string[,] strArray = new string[2, numberN]; //создаем двумерный массив

    for (int i = 0; i < numberN; i++)
    {
        string strPow = " " + Math.Pow(i + 1, pow).ToString() + " "; //Создаем строку с числами в степени
        int lengthStrPow = strPow.Length; //вычисляем длину строки

        string str = (i + 1).ToString(); //Создаем строку с числами без степени
        int lengthStr = str.Length; //вычисляем длину строки
        str =
            GetMultiChar(' ', (lengthStrPow - lengthStr) / 2)
            + str
            + GetMultiChar(' ', lengthStrPow - ((lengthStrPow - lengthStr) / 2) - lengthStr); //вычисляем количество пробелов с каждой стороны

        strArray[0, i] = str; //Заносим данные в двумерный массив
        strArray[1, i] = strPow;
    }
    return strArray;
}

//Метод вывода результата из двумерного массива
void PrintResult(string[,] strArray)
{
    for (int i = 0; i < strArray.Length / 2; i++)
    {
        Console.Write("|" + strArray[0, i]);
    }
    Console.WriteLine("|");

    for (int i = 0; i < strArray.Length / 2; i++)
    {
        Console.Write("|" + strArray[1, i]);
    }
    Console.WriteLine("|");
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
