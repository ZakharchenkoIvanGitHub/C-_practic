//==========================================
//#66 Задайте значения M и N. Напишите программу, которая найдёт
//сумму натуральных элементов в промежутке от M до N.
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

// Рекурентный метод суммирования чисел
int SumRec(int numM, int numN)
{
    if (numN < numM)return 0;        
    return (numM == numN) ? numN : numM + SumRec(numM + 1, numN);
}

PrintInfo("Сумма чисел от M до N: ",SumRec(ReadData("Введите число M"), ReadData("Введите число N")).ToString());
