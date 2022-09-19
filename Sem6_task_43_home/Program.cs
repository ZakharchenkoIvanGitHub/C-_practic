//==========================================
//#43   Напишите программу, которая найдёт точку пересечения двух прямых, заданных
//уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем
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
void PrintInfo(string line1, string line2 = "")
{
    Console.WriteLine(line1 + line2);
}

// Ищет точку пересечения
double[] PointFind(double b1, double k1, double b2, double k2)
{
    double[] xy = new double[2];
    xy[0] = (b2 - b1) / (k1 - k2);
    xy[1] = k1 * xy[0] + b1;
    return xy;
}

//Проверка на пересечение
bool InterCheck(int k1, int k2)
{
    if (k1 == k2)
        return false;
    else
        return true;
}

//Основная программа
PrintInfo(
    "Введите значения b1, k1, b2 и k2 уравнений y = k1 * x + b1, y = k2 * x + b2 \nи программа найдет точку пересечения двух прямых"
);
int b1 = ReadData("Введите b1");
int k1 = ReadData("Введите k1");
int b2 = ReadData("Введите b2");
int k2 = ReadData("Введите k2");

if (InterCheck(k1, k2))
{
    double[] xy = PointFind(b1, k1, b2, k2);
    PrintInfo("Точка пересечения двух прямых ", $"X = {xy[0]}, Y = {xy[1]}");
}
else
{
    PrintInfo("Линии не пересекаются");
}
