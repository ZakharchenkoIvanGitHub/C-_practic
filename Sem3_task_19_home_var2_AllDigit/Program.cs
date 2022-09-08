//==========================================
//#19 Напишите программу, которая принимает на вход пятизначное
//число и проверяет, является ли оно палиндромом.
//==========================================

//!!При тестировании программы на палиндромом любого числа пришлось ввести тип ulong

ulong ReadData(string greeting = "Введите данные")
//Получает строку заголовок
//Выдает введеное число, в случае ошибки выдает 0
{
    //Выводим сообщение
    Console.WriteLine(greeting);
    //считываем строку
    ulong.TryParse((Console.ReadLine() ?? "0"), out ulong number); // переводим в число
    return (number);
}

//Вычисление палиндрома любого числа
bool TestPolinAll(ulong num)
{
    int digit = (int)Math.Log10(num) + 1; //количество разрядов
    int j = 0;
    for (int i = digit - 1; i > (digit - 1 - digit / 2); i--)
    {
        if (((int)(num / Math.Pow(10, i) % 10)) != ((int)(num / Math.Pow(10, j) % 10)))
        {
            return false;
        }
        ;
        j++;
    }
    return true;
}

//Метод вывода ссобщений
void PrintResult(string line)
{
    Console.WriteLine(line);
}

PrintResult("Введите число и программа проверит, является ли оно палиндромом");
ulong num = ReadData("Введите N: ");
PrintResult(
    num != 0
        ? (TestPolinAll(num))
            ? "Полиндром"
            : "Не полиндром"
        : "Ошибка! Необходимо ввести число");