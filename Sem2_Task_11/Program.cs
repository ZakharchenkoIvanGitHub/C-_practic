//==========================================
//#11 Напишите программу, которая выводит случайное 
//трёхзначное число и удаляет вторую цифру этого числа.
//==========================================

    Console.WriteLine("медод 1");
    System.Random numberGenerator = new System.Random();
    int number = numberGenerator.Next(100, 1000);
    Console.WriteLine(number);
    int firstDigit = number / 100;
    int secondDigit = number % 10;
    Console.WriteLine(firstDigit*10+secondDigit);