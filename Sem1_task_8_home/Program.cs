//==========================================
//#8 Напишите программу, которая на вход принимает число (N),
//а на выходе показывает все чётные числа от 1 до N.

//==========================================
Console.WriteLine("Введите число N и программа выдаст все чётные числа от 1 до N");

Console.Write("Введите число: ");
string? inputLine = Console.ReadLine();

//проверка if (inputLineA != null && inputLineB != null) не работате, пустая строка не является null
if (inputLine != "") // Проверка на ввод пустой строки
{
    if (int.TryParse(inputLine, out int inputNumber)) //Проверка на ввод чисел
    {
        if (inputNumber > 1) // Проверка на положительное число
        {
            Console.Write("Чётные числа от 1 до " + inputNumber + ": ");

            /*   for (int i = 2; i <= inputNumber; i = i + 2)
              {
                  Console.Write(i);
  
                  if (i < inputNumber - 1)//Проверка, нужно ли ставить запятую
                  {
                      Console.Write(", ");
                  }
                  }*/


            int i = 2;
            while (i < inputNumber)
            {
                Console.Write(i + ", ");
                i += 2;
            }
            Console.Write(i);
        }
        else
        {
            Console.WriteLine("Ошибка! Число должно быть больше 1");
        }
    }
    else
    {
        Console.WriteLine("Ошибка! Необходимо вводить целые числа");
    }
}
else
{
    Console.WriteLine("Ошибка! Пустые значения не допускаются");
}
