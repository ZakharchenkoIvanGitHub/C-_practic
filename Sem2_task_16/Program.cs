//==========================================
//#16 Напишите программу, которая принимает на вход два числа
//и проверяет, является ли одно число квадратом другого.
//==========================================

int ReadData(string greeting = "Введите данные")
{
    //Выводим сообщение
    Console.WriteLine(greeting);

    //считываем число
    return int.Parse(Console.ReadLine() ?? "0");
}

//тест на квадрат
bool SqrTest(int firstNum, int secomdNum) {
if (firstNum == secomdNum*secomdNum)
{return true;}
else
{return false;}

 }

 void PrintData(int firstNum, int secomdNum){
    if (SqrTest(firstNum, secomdNum)){
        Console.WriteLine("Число "+firstNum+" квадрат числа "+secomdNum);
    }
    else
    { Console.WriteLine("Число "+firstNum+"квадрат числа "+secomdNum);}
 }

int num1 = ReadData("Введите число 1: ");
int num2 = ReadData("Введите число 2: ");

PrintData(num1, num2);
PrintData(num2, num1);