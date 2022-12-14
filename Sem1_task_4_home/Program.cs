//==========================================
//#4 Напишите программу, которая принимает на вход три числа
//и выдаёт максимальное из этих чисел.
//==========================================
Console.WriteLine("Введите три числа и программа определит максимальное число");

Console.Write("Введите число А: ");
string? inputLineA = Console.ReadLine();

Console.Write("Введите число B: ");
string? inputLineB = Console.ReadLine();

Console.Write("Введите число C: ");
string? inputLineC = Console.ReadLine();

//проверка if (inputLineA != null && inputLineB != null) не работате, пустая строка не является null
if (inputLineA != "" && inputLineB != "" && inputLineC != "") // Проверка на ввод пустой строки
{
    if (
        int.TryParse(inputLineA, out int inputNumberA)
        && int.TryParse(inputLineB, out int inputNumberB)
        && int.TryParse(inputLineC, out int inputNumberC)
    ) //Проверка на ввод чисел
    {
        int max;

        //============================================================= старый  метод
        if (inputNumberA > inputNumberB) //первая проверка A,B
        {
            max = inputNumberA;
        }
        else
        {
            max = inputNumberB;
        }

        if (inputNumberC > max) //вторая проверка max,C
        {
            max = inputNumberC;
        }
        Console.WriteLine("Максимальное число старым методом: " + max);

        //============================================================= метод Math.Max()
        max = Math.Max(Math.Max(inputNumberA, inputNumberB), inputNumberC);

        Console.WriteLine("Максимальное число методом Math.Max(): " + max);

        //============================================================= с тенарным оператором
        max = inputNumberA > inputNumberB ? inputNumberA : inputNumberA;
        max = max > inputNumberC ? max : inputNumberC;

        Console.WriteLine("Максимальное число с тенарным оператором: " + max);
    }
    else
    {
        Console.WriteLine("Ошибка! Необходимо вводить целые числа");
    }
}
else
{
    Console.WriteLine("Ошибка! Пустые значения не допускаются");
}
