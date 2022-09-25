//==========================================
//#53  Задайте двумерный массив. Напишите программу,
//которая поменяет местами первую и последнюю строку массива.
//==========================================

// Запрос данных пользователяю, принимает строку заголовок.
// Выдает введеное число, в случае ошибки выдает 0.
int ReadData(string greeting = "Введите данные")
{
    Console.WriteLine(greeting);
    int.TryParse((Console.ReadLine() ?? "0"), out int number); // переводим в число
    return (number);
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

//Печатает двумерный массив
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

// Меняет местами первую и последнеюю строчку
int [,] Change2DArray(int [,] array){
int buf = 0;
for (int i = 0; i < array.GetLength(1); i++){
buf = array[array.GetLength(0)-1,i];
array[array.GetLength(0)-1,i] =array[0,i];
array[0,i] = buf;
}
return array;
}

int row = ReadData("Введите количество строк ");
int column = ReadData("Введите количество столбцов ");

int[,] arr2D = Gen2DArr(row, column, 10, 100);

Print2DArray(arr2D);
Console.WriteLine();
Print2DArray(Change2DArray(arr2D));


