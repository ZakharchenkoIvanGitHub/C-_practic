//==========================================
//#40  Напишите программу, которая принимает на вход три числа и
//проверяет, может ли существовать треугольник с сторонами такой длины.
//==========================================

bool TrglTest(int a, int b, int c)
{
    bool res = false;
    if ((a + b > c) && (a + c > b) && (c + b > a))
    {
        res = true;
    }
    return res;
}
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
void PrintInfo(string line)
{
    Console.WriteLine(line);
}

int a = ReadData("выедите число a: ");
int b = ReadData("выедите число b: ");
int c = ReadData("выедите число c: ");

PrintInfo(TrglTest(a, b, c) ? "Такой треугольник может быть" : "Такого треугольника не может быть");
