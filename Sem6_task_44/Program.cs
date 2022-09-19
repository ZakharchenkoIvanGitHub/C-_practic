//==========================================
//#44  Не используя рекурсию, выведите первые N чисел
//Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
//==========================================

int ReadData(string greeting = "Введите данные")
//Получает строку заголовок
//Выдает введеное число, в случае ошибки выдает 0
{
    //Выводим сообщение
    Console.WriteLine(greeting);
    //считываем строку
    int.TryParse((Console.ReadLine() ?? "0"), out int number); // переводим в число
    return (number);
}

//выводит строку на печать
void PrintInfo(string line)
{
    Console.WriteLine(line);
}

string FibNum(int num)
{
    string res = "";
    int first = 0;
    int last = 1;
    int buf = 0;
    for (int i = 0; i < num; i++)
    {
        res = res + " " + first;
        buf = first + last;
        first = last;
        last = buf;
    }
    return res;
}

PrintInfo(FibNum(ReadData()));