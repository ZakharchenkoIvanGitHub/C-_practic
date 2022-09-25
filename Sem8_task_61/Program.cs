//==========================================
//#61 Вывести первые N строк треугольника Паскаля.
//Сделать вывод в виде равнобедренного треугольника
//==========================================

//вычислием факториал
float factorial(int n)
{
    float i,
        x = 1;
    for (i = 1; i < n; i++)
    {
        x *= i;
    }
    return x;
}

// Запрос данных пользователяю, принимает строку заголовок.
// Выдает введеное число, в случае ошибки выдает 0.
int ReadData(string greeting = "Введите данные")
{
    Console.WriteLine(greeting);
    int.TryParse((Console.ReadLine() ?? "0"), out int number); // переводим в число
    return (number);
}

//выводит треугольник паскаля
void PrintTrianglePascal(int n)
{

    for (int i = 0; i < n; i++)
    {
        for (int c = 0; c <= (n - i); c++) //выводим пробелы перед строчкой
        {
            Console.Write(" ");
        }

        for (int c = 0; c <= i; c++)
        {
            Console.Write(" ");
            Console.Write(factorial(i) / (factorial(c) * factorial(i - c)));
        }
        Console.WriteLine();
        Console.WriteLine();
    }

}

PrintTrianglePascal(ReadData("Введите количество строк треугольника"));
