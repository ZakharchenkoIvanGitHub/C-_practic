//==========================================
//#26 Напишите программу, которая принимает на 
//вход число и выдаёт количество цифр в числе
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

// Вариант с длинной строки
 int CalculateDigitsString(int num)
 {
     string numString = num.ToString();
     return numString.Length;
 }

 // Вариант Лилии
 int CalculateDigitsStringLili(int num)
 {
     char [] numString = num.ToString().ToCharArray();

     return numString.Length;
 }

// Вариант с логарифмом
int CalculateDigits(int num)
{
    return (int)(Math.Log10(num) + 1);
}

//Вариант с делением на 10
int DigitCount(int num){
    int sum = 0;
    while (num>0)
    {
        sum++;
        num=num/10;
    }
    return sum;
};


int number = ReadData("Введите число: ");

PrintResult("Вариант с длинной строки ");
DateTime d1 = DateTime.Now;
int numberOfDigits = CalculateDigitsString(number);
Console.WriteLine(DateTime.Now-d1);
PrintResult("Количество цифр в числе: " + numberOfDigits);

PrintResult("Вариант с логарифмом ");
d1 = DateTime.Now;
numberOfDigits = CalculateDigits(number);
Console.WriteLine(DateTime.Now-d1);
PrintResult("Количество цифр в числе: " + numberOfDigits);

PrintResult("Вариант Лилии ");
d1 = DateTime.Now;
numberOfDigits = CalculateDigitsStringLili(number);
Console.WriteLine(DateTime.Now-d1);
PrintResult("Количество цифр в числе: " + numberOfDigits);

PrintResult("Вариант с делением на 10 ");
d1 = DateTime.Now;
numberOfDigits = DigitCount(number);
Console.WriteLine(DateTime.Now-d1);
PrintResult("Количество цифр в числе: " + numberOfDigits);

