//==========================================
//#67 Напишите прграмму, которая будет принимать число N
// и аозвращить сумму его чисел
//==========================================

// Запрос данных пользователяю, принимает строку заголовок.
// Выдает введеное число, в случае ошибки выдает 0.
int ReadData(string greeting = "Введите данные")
{
    Console.WriteLine(greeting);
    int.TryParse((Console.ReadLine() ?? "0"), out int number); // переводим в число
    return (number);
}

// Выводит строку на печать.
void PrintInfo(string line1, string line2 = "")
{
    Console.WriteLine(line1 + line2);
}

int RecSum(int numN)
{
    //точка остановки
    //  if return 0;
    // return numN % 10 + RecSum(numN / 10);

    return numN == 0 ? 0 : numN % 10 + RecSum(numN / 10);
}

int num = ReadData();

PrintInfo(RecSum(num).ToString());
