//==========================================
//#69 Напишите прграмму, которая будет принимать 2 числа А и В
// возыедите А в степень В с помощью рекурсии
//==========================================

// Запрос данных пользователяю, принимает строку заголовок.
// Выдает введеное число, в случае ошибки выдает 0.
int ReadData(string greeting = "Введите данные")
{
    Console.WriteLine(greeting);
    int.TryParse((Console.ReadLine() ?? "0"), out int number); // переводим в число
    return (number);
}

// Выводит строку на печать.
void PrintInfo(string line1, string line2 = "")
{
    Console.WriteLine(line1 + line2);
}

int RecPow(int numA, int numB)
{
    //точка остановки
    //  if return 0;
    // return numN % 10 + RecSum(numN / 10);

    return numB == 1 ? numA : numA * RecPow(numA, numB - 1);
}

int MyPow(int numA, int numB)
{
    if (numB == 2)
    {
        return numA * numA;
    }
    if (numB == 1)
    {
        return numA;
    }

    if (numB % 2 == 0)
    {
        return MyPow(numA , numB / 2) * MyPow(numA, numB / 2);
    }
    else
    {
        return MyPow(numA , numB / 2) * MyPow(numA, numB / 2 + 1);
    }
}

int numA = ReadData("Введите число А");
int numB = ReadData("Введите число B");

PrintInfo(MyPow(numA, numB).ToString());
