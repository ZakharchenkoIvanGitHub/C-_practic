//==========================================
//#19 Напишите программу, которая принимает на вход пятизначное
//число и проверяет, является ли оно палиндромом.
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

//Вычисление палиндрома через словарь
bool TestPolinDict(int num)
{
    if ((int)Math.Log10(num)==4){ //проверка на пятизначное число
    Dictionary<int, int > dict= GenerateDictionary();

    if (dict[(int)num/1000]==(int)num % 100) return true;

}
    return false;
}

//Генератор словаря
Dictionary<int, int> GenerateDictionary()
{
    Dictionary<int, int> dict = new Dictionary<int, int>(); //Создаем словарь
    for (int i = 1; i <= 9; i++)
        for (int j = 1; j <= 9; j++)
            dict.Add((10 * i + j), (10 * j + i));
    return dict;
}

//Метод вывода ссобщений
void PrintResult(string line)
{
    Console.WriteLine(line);
}

PrintResult("Введите пятизначное число и программа проверит, является ли оно палиндромом");
int num = ReadData("Введите N: ");
PrintResult(
    num != 0
        ? (TestPolinDict(num))
            ? "Полиндром"
            : "Не полиндром"
        : "Ошибка! Необходимо ввести число");
