//==========================================
//#29* Написать программу которая из имен через запятую
//выберет случайное имя и выведет в терминал
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

//Парсит строку, возвращает массив подстрок
string[] Parser(string str)
{
    return str.Split(',');
}

//Выбирает случайное имя из массива
string GenRandName(string[] strArray)
{
    Random ren = new Random();
    return strArray[ren.Next(0, strArray.Length)];
}

//выводит строку на печать
void PrintResult(string line)
{
    Console.WriteLine(line);
}

PrintResult("За пивом бежит "+GenRandName(Parser(ReadData("Введите имена через запятую"))));