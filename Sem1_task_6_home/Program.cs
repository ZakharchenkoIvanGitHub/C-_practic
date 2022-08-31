//==========================================
//#6 Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).

//==========================================
Console.WriteLine("Введите три числа и программа определит является ли число чётным");

Console.Write("Введите число: ");
string? inputLine = Console.ReadLine();

//проверка if (inputLineA != null && inputLineB != null) не работате, пустая строка не является null
if (inputLine != "") // Проверка на ввод пустой строки
{
    if (int.TryParse(inputLine, out int inputNumber)) //Проверка на ввод чисел
    {

        if (inputNumber % 2 == 0) // проверка на четность
        {
            Console.WriteLine("Число " + inputNumber + " четное");
        }
        else

        {
            Console.WriteLine("Число " + inputNumber + " не четное");
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