//==========================================
//#58 Задайте две матрицы. Напишите программу,
//которая будет находить произведение двух матриц.
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

// Генерация случайного 2D массива.
int[,] Gen2DArr(int countRow, int countColumn, int arrMin, int arrMax)
{
    int[,] arr2D = new int[countRow, countColumn];
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
            arr2D[i, j] = rnd.Next(arrMin, arrMax);
        }
    }
    return arr2D;
}

// Печатает двумерный массив.
void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

// Произведение arrayC = arrayA Х arrayB.
int[,] MatrixProduct(int[,] arrayA, int[,] arrayB)
{
    int[,] arrayC = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
    for (int i = 0; i < arrayC.GetLength(0); i++)
    {
        for (int j = 0; j < arrayC.GetLength(1); j++)
        {
            for (int k = 0; k < arrayA.GetLength(1); k++)
            {
                arrayC[i, j] += arrayA[i, k] * arrayB[k, j];
            }
        }
    }
    return arrayC;
}

// Основная программа.
int rowA = ReadData("Введите количество строк матрицы А");
int columnA = ReadData("Введите количество столбцов матрицы А");
int rowB = columnA;
PrintInfo("Количество строк матрицы B равно ", rowB.ToString());
int columnB = ReadData("Введите количество столбцов матрицы B");

int[,] arrayA = Gen2DArr(rowA, columnA, 0, 10);
PrintInfo("\n", "матрица №1:");
Print2DArray(arrayA);

int[,] arrayB = Gen2DArr(rowB, columnB, 0, 10);
PrintInfo("\n", "матрица №2:");
Print2DArray(arrayB);

PrintInfo("\n", "Произведение матриц: ");
Print2DArray(MatrixProduct(arrayA, arrayB));
