//==========================================
//#10 Напишите программу, которая принимает на вход 
//трёхзначное число и на выходе показывает вторую цифру этого числа.
//==========================================


//Получаем  число от пользователя
//Передаем приветствие
string? ReadData(string greeting = "Введите данные")
{
    Console.WriteLine(greeting);
    Console.Write("Введите число: ");
    return Console.ReadLine();
}

//Проверяем на ввод трех символов и переводим в число
//В cлучае ошибки возвратим -1
int check(string line)
{
    int number = 0;
    if (
        (line.Length == 3)// Проверка на длину символов
        && 
        int.TryParse(line, out number)// переводим в число
    ) 
    {
        return number;
    }
    else
    {
        Console.WriteLine("Ошибка! Неправильный ввод");
        return -1;
    }
}

//вычисляем вторую цифру
int calculate(int number) {
    return (number%100)/10;
 }

//Выводит результат
void myprint(int number, int digit)
{
    Console.WriteLine("Вторая цифра числа " + number + " является " + digit);
}

//Основная программа
string inputLine = ReadData("Введите трехначное число и программа покажет вторую цифру этого числа");
int number = check(inputLine);
if (number != -1)
{
    int digit = calculate(number);
    myprint(number, digit);
}
