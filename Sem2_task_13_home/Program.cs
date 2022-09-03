//==========================================
//#13 Напишите программу, которая выводит третью цифру заданного
//числа или сообщает, что третьей цифры нет
//==========================================


//Получаем  число от пользователя
//Передаем приветствие
string? ReadData(string greeting = "Введите данные")
{
    Console.WriteLine(greeting);
    Console.Write("Введите число: ");
    return Console.ReadLine();
}

//Переводим в число
//В cлучае ошибки возвратим -1
int check(string line)
{
    int number = 0;
    if (
        int.TryParse(line, out number) // переводим в число
    )
    {
        return number;
    }
    else
    {
        Console.WriteLine("Ошибка! Неправильный ввод");
        return -1;
    }
}

//вычисляем заданную цифру
int calculate(int number, int searchDigit)
{
    int leng = (int)Math.Log10(number) + 1; //количество символов
    if (leng >= 3)
    {
        return (number % (int)Math.Pow(10, leng - 2)) / (int)Math.Pow(10, leng - 3);
    }
    else
        return -1;
}

//Выводит результат
void myprint(int number, int digit)
{
    if (digit == -1)
    {
        Console.WriteLine("В числе " + number + " третьей цифры нет");
    }
    else
    {
        Console.WriteLine("Третья цифра числа " + number + " является " + digit);
    }
}

//Основная программа
string inputLine = ReadData("Введите число и программа выведит третью цифру заданного числа");
int number = check(inputLine);
if (number != -1)
{
    int digit = calculate(number, 3);
    myprint(number, digit);
}
