//==========================================
//#64 Задайте значение N. Напишите программу которая выдает
// все натуральные числа в промежутке от N до 1
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

// Рекурентный метод вывода чисел
string LineGenRec(int numN)
{
    return (numN == 0) ? "" : numN + " " + LineGenRec(numN - 1);
}

PrintInfo(LineGenRec(ReadData("Введите число N")));
