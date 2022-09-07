//==========================================
//#20 Напишите программу, которая принимает на входкоординаты двух точек
//и находит расстояние между ними в 2D пространстве.
//==========================================

int ReadData(string greeting = "Введите данные")
{
    //Выводим сообщение
    Console.WriteLine(greeting);
    //считываем число
    return int.Parse(Console.ReadLine() ?? "0");
}

double Calculate(int x1, int y1, int x2, int y2)
{
    double res = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));
    return res;
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}

int x1 = ReadData("Введите x1: ");
int y1 = ReadData("Введите y1: ");
int x2 = ReadData("Введите x2: ");
int y2 = ReadData("Введите y2: ");

PrintResult("расстояние между точками = " + Math.Round(Calculate(x1, y1, x2, y2), 2));
