//==========================================
//#12 Напишите программу, которая будет принимать на вход два числа и выводить,
//является ли второе число кратным первому. Если второе число некратно
//первому, то программа выводит о статок от деления .
//==========================================

Console.Write("Введите число А: ");
string? inputLineA = Console.ReadLine();

Console.Write("Введите число B: ");
string? inputLineB = Console.ReadLine();

if (inputLineA != "" && inputLineB != "" ) // Проверка на ввод пустой строки
{
    if (
        int.TryParse(inputLineA, out int inputNumberA)
        && int.TryParse(inputLineB, out int inputNumberB)
        
    ) //Проверка на ввод чисел
    {
//Вариант 1
        if ( inputNumberA%inputNumberB ==0){

            Console.WriteLine(" А кратно B ");
        }else{
             Console.WriteLine(" А  не кратно B, остаток от деления "+inputNumberA%inputNumberB);
        };
//Вариант 2
Console.WriteLine(
    (inputNumberA%inputNumberB==0) ? 
    (" А кратно B "):
    (" А  не кратно B, остаток от деления "+inputNumberA%inputNumberB));

    
    }
}