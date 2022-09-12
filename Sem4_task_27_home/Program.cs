//==========================================
//#27 Напишите программу, которая принимает на
//вход число и выдаёт сумму цифр в числе.
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
void PrintResult(string line)
{
    Console.WriteLine(line);
}

//Вариант с делением на 10
int CalculateNum(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum += num % 10;
        num = num / 10;
    }
    return sum;
}
;

//Вариант со строками
int CalculateStr(int num)
{
    string str = num.ToString();
    int sum = 0;
    foreach (char numChar in str)
    {
        sum += (int)char.GetNumericValue(numChar);
    }

    return sum;
}
;

//Основная программа
PrintResult("Введите число(N) и программа выдаст сумму чисел в числе");
int num = ReadData("Введите N: ");

if (num != 0)
{
    //Возвращает новое число из чисел принимаемого
    int NewNum(int num)
    {
        return 10 * (num % ((int)Math.Pow(10, (int)Math.Log10(num))))
            + (num / ((int)Math.Pow(10, (int)Math.Log10(num))));
    }

    PrintResult("Вариант вещественными числами");
    DateTime d1 = DateTime.Now;
    PrintResult(CalculateNum(num).ToString());
    Console.WriteLine(DateTime.Now - d1);

    num = NewNum(num); // Создаем новое число на основании веденных чисел
    Console.WriteLine(num);

    PrintResult("Вариант со строками");
    DateTime d2 = DateTime.Now;
    PrintResult(CalculateStr(num).ToString());
    Console.WriteLine(DateTime.Now - d2);
}
else
{
    PrintResult("Ошибка! Необходимо ввести число");
}
;
//Итог. Как ни крути, первое действие всегда дольше. Даже если их менить местами.
//Уже создал отдельную переменную (переставил цифры местами), стобы небыло эффекта ускорения, 
//но умный компилятор все равно первый метод считает дольше.