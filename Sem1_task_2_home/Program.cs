//==========================================
//#2 Напишите программу, которая на вход принимает два числа
//и выдаёт, какое число большее, а какое меньшее.
//==========================================
Console.WriteLine("Введите два числа и программа определит какое число большее, а какое меньшее");

Console.Write("Введите число А: ");
string? inputLineA = Console.ReadLine();

Console.Write("Введите число B: ");
string? inputLineB = Console.ReadLine();


//проверка if (inputLineA != null && inputLineB != null) не работате, пустая строка не является null
if (inputLineA != "" && inputLineB != "") // Проверка на ввод пустой строки
{
    if (int.TryParse(inputLineA, out int inputNumberA) && int.TryParse(inputLineB, out int inputNumberB)) //Проверка на ввод чисел
    {
        if (inputNumberA > inputNumberB)
        {
            Console.WriteLine("Число А=" + inputNumberA + " больше числа В=" + inputNumberB);
        }
        else if(inputNumberA < inputNumberB)
        {
            Console.WriteLine("Число А=" + inputNumberA + " меньше числа В=" + inputNumberB);
        }
        else
        {
            Console.WriteLine("Число А=" + inputNumberA + " равно числу В=" + inputNumberB);
        }
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