//==========================================
//#68 Напишите программу вычисления функции Аккермана с 
//помощью рекурсии. Даны два неотрицательных числа m и n.
//==========================================

// Запрос данных пользователяю, принимает строку заголовок.
// Выдает введеное число, в случае ошибки выдает 0.
uint ReadData(string greeting = "Введите данные")
{
    Console.WriteLine(greeting);
    uint.TryParse((Console.ReadLine() ?? "0"), out uint number); // переводим в число
    return (number);
}

// Выводит строку на печать.
void PrintInfo(string line1, string line2 = "")
{
    Console.WriteLine(line1 + line2);
}

// Рекурентный метод вычисления функции Аккермана
ulong AkkermanRec(ulong m, ulong n)
{
   if (m==0) return n+1;
   if (n==0) return AkkermanRec(m-1,1);
   return AkkermanRec (m-1,AkkermanRec(m,n-1));
}

PrintInfo("A(m,n) = ",AkkermanRec(ReadData("Введите число m"), ReadData("Введите число n")).ToString());
