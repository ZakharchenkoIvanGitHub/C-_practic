﻿//==========================================
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

//Вычисление пятизначного палиндрома
bool TestPolin5Digit(int num)
{
    return ((num / 10000 == num % 10) && ((num / 1000) % 10 == (num / 10) % 10));
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
        ? (TestPolin5Digit(num))
            ? "Полиндром"
            : "Не полиндром"
        : "Ошибка! Необходимо ввести число"
);