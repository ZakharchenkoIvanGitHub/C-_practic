//==========================================
//#12 Напишите программу, которая будет принимать на вход два числа и выводить,
//является ли второе число кратным первому. Если второе число некратно
//первому, то программа выводит о статок от деления .
//==========================================
int inputNumberA=0;
int inputNumberB=0;
bool result=false;
string? inputLineA;
string? inputLineB;

//Получаем 2 числа от пользователя
void ReadData()
{
    Console.Write("Введите число А: ");
    inputLineA = Console.ReadLine();

    Console.Write("Введите число B: ");
    inputLineB = Console.ReadLine();
}

//Определяем кратность чисел
void ColculateData()
{
    if (inputLineA != "" && inputLineB != "") // Проверка на ввод пустой строки
    {
        if (
            int.TryParse(inputLineA, out inputNumberA) && int.TryParse(inputLineB, out inputNumberB)
        ) //Проверка на ввод чисел
        {
            result = inputNumberA % inputNumberB == 0;
        }
    }
}

//Выводим данные вычисления
void PrintData()
{
Console.WriteLine(result ? (" А кратно B "): (" А  не кратно B, остаток от деления "+inputNumberA%inputNumberB));

}

ReadData();
ColculateData();
PrintData();