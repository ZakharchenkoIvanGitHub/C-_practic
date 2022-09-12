//==========================================
//#25 Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную
//степень B. * Написать калькулятор с операциями +, -, /, * и возведение в степень
//==========================================

string ReadData(string greeting = "Введите данные")
//Получает строку заголовок
//Выдает введенные данные
{
    //Выводим сообщение
    Console.WriteLine(greeting);
    //считываем строку

    return Console.ReadLine() ?? "0";
}

//выводит строку на печать
void PrintResult(double res, string[] strArrray)
{
    Console.WriteLine($"{strArrray[0]} {strArrray[1]} {strArrray[2]} = {Math.Round(res,2)}");
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
double Calculate(string oper, double numA, double numB)
{
Console.WriteLine(numA+" "+numB);

    switch (oper)
    {
        case "+":
            return numA + numB;
            

        case "-":
            return numA - numB;
            

        case "*":
            return numA * numB;
          

        case "/":
            return numA / numB;
           

        case "^":
            return Math.Pow(numA, numB);
           
        default:
            return 0;
           
    }
}

//Основная прогррамма
string str = ReadData(
    "Введите задание в формате <число> <операция> <число> \nнапример 5 + 9 или 5,7*9,1 и программа выдаст ответ. \nДоступные операции +, -, /, *,^"
);
string[] strArrray = Parser(str);

if (double.TryParse(strArrray[0], out double numA) && double.TryParse(strArrray[2], out double numB))
{
    PrintResult(Calculate(strArrray[1], numA, numB), strArrray);
}
else
    Console.WriteLine("Ошибка, не верный формат введенных данных.");
