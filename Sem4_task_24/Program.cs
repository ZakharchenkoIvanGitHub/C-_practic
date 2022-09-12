//==========================================
//#24 Напишите программу, которая принимает на вход координаты двух
//точек и находит расстояние между ними в 3D пространстве.
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

int VariantSumSimple(int numA)
{
    int sumOfNubers = 0;
    for (int i = 0; i <= numA; i++)
    {
        sumOfNubers += i;
    }
    return sumOfNubers;
}

int VariantSumGaus(int numA){

    int sumOfNubers =0;
    sumOfNubers = ((1+ numA)*numA)/2;
    return sumOfNubers; 
}

int numberA = ReadData();

DateTime d1 = DateTime.Now;
int res1 = VariantSumSimple(numberA);
Console.WriteLine(DateTime.Now-d1);
PrintResult("Сумма чисел "+res1);

DateTime d2 = DateTime.Now;
int res2 = VariantSumGaus(numberA);
Console.WriteLine(DateTime.Now-d2);
PrintResult("Сумма чисел "+res2);
