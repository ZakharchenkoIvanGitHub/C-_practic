//==========================================
//#42  Напишите программу, которая будет
//преобразовывать десятичное число в двоичное
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


string BinConvert(int a){
string res = string.Empty;
while (a>0){
    res =  a%2+res;
    a=a/2;
}
return res;
}

PrintInfo(BinConvert(ReadData("введите число")));