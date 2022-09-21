//==========================================
//#47  Задайте двумерный массив размером m×n,
//заполненный случайными вещественными числами
//==========================================

ConsoleColor[] col = new ConsoleColor[]
{
    ConsoleColor.Black,
    ConsoleColor.Blue,
    ConsoleColor.Cyan,
    ConsoleColor.DarkBlue,
    ConsoleColor.DarkCyan,
    ConsoleColor.DarkGray,
    ConsoleColor.DarkGreen,
    ConsoleColor.DarkMagenta,
    ConsoleColor.DarkRed,
    ConsoleColor.DarkYellow,
    ConsoleColor.Gray,
    ConsoleColor.Green,
    ConsoleColor.Magenta,
    ConsoleColor.Red,
    ConsoleColor.White,
    ConsoleColor.Yellow
};

// Запрос данных пользователяю, принимает строку заголовок.
// Выдает введеное число, в случае ошибки выдает 0.
int ReadData(string greeting = "Введите данные")
{
    Console.WriteLine(greeting);
    int.TryParse((Console.ReadLine() ?? "0"), out int number); // переводим в число
    return (number);
}

// Генерация случайного 2D массива.
double[,] Gen2DArr(int countRow, int countColumn, int arrMin, int arrMax)
{
    double[,] arr2D = new double[countRow, countColumn];
    Random rnd = new Random();

    if (arrMin > arrMax)
    {
        int temp = arrMax;
        arrMax = arrMin;
        arrMin = temp;
    }

    for (int i = 0; i < arr2D.GetLength(0); i++)
    {
        for (int j = 0; j < arr2D.GetLength(1); j++)
        {
            arr2D[i, j] = rnd.Next(arrMin, arrMax) * rnd.NextDouble();
        }
    }
    return arr2D;
}

// Печатает двумерный массив.
void Print2DArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            PrintStringColor(Math.Round(array[i, j], 2) + "\t");
        }
        Console.WriteLine();
    }
}

// Печатает ячейку цветными символами.
void PrintStringColor(string data)
{
    foreach (char symbol in data)
    {
        Console.ForegroundColor = col[new System.Random().Next(0, 16)];
        Console.Write(symbol);
        Console.ResetColor();
    }
}

int row = ReadData("Введите количество строк ");
int column = ReadData("Введите количество столбцов ");

Print2DArray(Gen2DArr(row, column, 10, 100));
