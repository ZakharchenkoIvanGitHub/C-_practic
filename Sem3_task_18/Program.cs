//==========================================
//#18 Напишите программу, которая по заданному номеру четверти, показывает 
//диапазон возможных координат точек в этой четверти (x и y).
//==========================================

int ReadData(string greeting = "Введите данные")
{
    //Выводим сообщение
    Console.WriteLine(greeting);
    //считываем число
    return int.Parse(Console.ReadLine() ?? "0");
}

string QuterBorderAsk(int numQuter)
{
    if (numQuter==1)
        return "x>0 y>0";
    if (numQuter==2)
        return "x<0 y>0";
    if (numQuter==3)
        return "x<0 y<0";
    if (numQuter==4)
        return "x>0 y<0";
    return "";
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}

int numQuter = ReadData("Введите номер четверти: ");


string res = QuterBorderAsk(numQuter);

PrintResult(res);
