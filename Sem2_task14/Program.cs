//==========================================
//#14 Напишите программу, которая принимает на вход
//число и проверяет, кратно ли оно одновременно 7 и 23.
//==========================================

Console.Write("Введите число: ");
string? inputLine = Console.ReadLine();

if (inputLine != "") // Проверка на ввод пустой строки
{
    if (int.TryParse(inputLine, out int inputNumber)) //Проверка на ввод чисел
    {
        Console.WriteLine(
            (inputNumber % 7 == 0 && inputNumber % 23 == 0)
                ? (inputNumber+"  кратно 7 и 23 ")
                : (inputNumber+" не кратно 7 и 23 ")
        );
    }
}
