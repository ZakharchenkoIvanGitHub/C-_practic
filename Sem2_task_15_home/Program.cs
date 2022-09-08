//==========================================
//#15 Напишите программу, которая принимает на вход цифру, обозначающую
//день недели, и проверяет, является ли этот день выходным
//==========================================


//Получаем  число от пользователя
//Передаем приветствие
string ReadData(string greeting = "Введите данные")
{
    Console.WriteLine(greeting);
    Console.Write("Введите число: ");
    return Console.ReadLine()??"0";
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
string calculate(int numberDay)
{
    Dictionary<int, string> dayWeek = new Dictionary<int, string>(); //Создаем словарь
    dayWeek.Add(1, "Понедельник - рабочий день");
    dayWeek.Add(2, "Вторник - рабочий день");
    dayWeek.Add(3, "Среда - рабочий день");
    dayWeek.Add(4, "Четверг - рабочий день");
    dayWeek.Add(5, "Пятница - рабочий день");
    dayWeek.Add(6, "Суббота - выходной");
    dayWeek.Add(7, "Воскреснье - выходной");

    try
    {
        return dayWeek[numberDay];
    }
    catch (KeyNotFoundException) // Исключение при отсутствии дня недели
    {
        return "Дня недели с номером " + numberDay + " не существует";
    }
}

//Выводит результат
void myprint(string message)
{
    Console.WriteLine(message);
}

//Основная программа
string inputLine = ReadData("Введите номер дня недели");
int number = check(inputLine);
if (number != -1)
{
    string str = calculate(number);
    myprint(str);
}
