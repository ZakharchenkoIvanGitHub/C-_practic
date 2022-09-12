//==========================================
//#25 Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную
//степень B. * Написать калькулятор с операциями +, -, /, * и возведение в степень
//==========================================

string ReadData(string greeting = "Введите данные")
//Получает строку заголовок
//Выдает введеное число, в случае ошибки выдает 0
{
    //Выводим сообщение
    Console.WriteLine(greeting);
    //считываем строку

    return Console.ReadLine() ?? "0";
}

//выводит строку на печать
void PrintResult(int res, string[] strArrray)
{
    Console.WriteLine($"{strArrray[0]} {strArrray[1]} {strArrray[2]} = {res}");
}

// распарсивает строку в массив [число] [операция] [число]
string[] Parser(string str)
{
    char oper = '\0';

    if (str.Contains("+"))
    {
        oper = '+';
    }
    else if (str.Contains("-"))
    {
        oper = '-';
    }
    else if (str.Contains("/"))
    {
        oper = '/';
    }
    else if (str.Contains("*"))
    {
        oper = '*';
    }
    else if (str.Contains("^"))
    {
        oper = '^';
    }
    ;

    return SubParser(str, oper);
}

//вспомогательный метод парсинга, возвращает массив данных
string[] SubParser(string str, char oper)
{
    string[] strArrray = new string[3];
    if (oper != '\0')
    {
        str = str.Trim();
        int index = str.IndexOf(oper);

        Console.WriteLine(str +index);
        strArrray[0] = str.Substring(0, index).Trim();
        strArrray[1] = str.Substring(index, 1).Trim();
        strArrray[2] = str.Substring(index + 1).Trim();
    }
    return strArrray;
}

//метод калькулятора
int Calculate(string oper, int numA, int numB)
{
    switch (oper)
    {
        case "+":
            return numA + numB;
            break;

        case "-":
            return numA - numB;
            break;

        case "*":
            return numA * numB;
            break;

        case "/":
            return numA / numB;
            break;

        case "^":
            return (int)Math.Pow(numA, numB);
            break;

        default:
            return 0;
            break;
    }
}

//Основная прогррамма
string str = ReadData(
    "Введите задание в формате <число> <операция> <число> \nнапример 5 + 9 или 5+9 и программа выдаст ответ. \nДоступные операции +, -, /, *,^"
);
string[] strArrray = Parser(str);

if (int.TryParse(strArrray[0], out int numA) && int.TryParse(strArrray[2], out int numB))
{
    PrintResult(Calculate(strArrray[1], numA, numB), strArrray);
}
else
    Console.WriteLine("Ошибка, не верный формат введенных данных.");
