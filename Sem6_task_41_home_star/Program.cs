//==========================================
//#41   Пользователь вводит с клавиатуры M чисел. Посчитайте,
//сколько чисел больше 0 ввёл пользователь.
//==========================================

//выводит строку на печать
void PrintInfo(string line1, string line2 = "")
{
    Console.WriteLine(line1 + line2);
}

//Определяет нажатую клавишу
char DefineKey(ConsoleKeyInfo input)
{
    switch (input.Key)
    {
        case ConsoleKey.D1
        or ConsoleKey.NumPad1:
            return '1';
        case ConsoleKey.D2
        or ConsoleKey.NumPad2:
            return '2';
        case ConsoleKey.D3
        or ConsoleKey.NumPad3:
            return '3';
        case ConsoleKey.D4
        or ConsoleKey.NumPad4:
            return '4';
        case ConsoleKey.D5
        or ConsoleKey.NumPad5:
            return '5';
        case ConsoleKey.D6
        or ConsoleKey.NumPad6:
            return '6';
        case ConsoleKey.D7
        or ConsoleKey.NumPad7:
            return '7';
        case ConsoleKey.D8
        or ConsoleKey.NumPad8:
            return '8';
        case ConsoleKey.D9
        or ConsoleKey.NumPad9:
            return '9';
        case ConsoleKey.D0
        or ConsoleKey.NumPad0:
            return '0';
        case ConsoleKey.Enter:
            return 'Q';
        case ConsoleKey.OemComma:
            return ',';
        case ConsoleKey.Spacebar:
            return ' ';
        case ConsoleKey.OemMinus:
            return '-';
        default:
            return '\0';
    }
}

//метод ввода данных, возвращает массив вещественных чисел
double[] InputData()
{
    string res = string.Empty;
    bool run = true;
    bool banOemComma = false; // Запрет запятой
    bool banSpacebar = true; // Запрет пробела
    bool banOemMinus = false; // Запрет минуса

    while (run)
    {
        char key = DefineKey(Console.ReadKey(true));
        if (key != '\0')
        {
            if (key == 'Q')
            {
                run = false;
                Console.WriteLine();
            }
            else
            {
                if (//запрещенные символы
                    (key == ',' && banOemComma)
                    || (key == ' ' && banSpacebar)
                    || (key == '-' && banOemMinus)
                ) 
                    continue;

                res = res + key;
                Console.Write(key.ToString());

                if (key == ' ')
                {
                    banOemMinus = false; //разрешаем минус после пробела
                    banSpacebar = true; // Запрещаем пробел после пробела
                    banOemComma = false; // Разрешаем запятую после пробела
                }

                if (key == '-')
                {
                    banOemMinus = true; // Запрещаем минус после минуса
                }

                if (key == ',')
                {
                    banOemMinus = true; // Запрещаем минус после минуса
                    banOemComma = true; // Запрещаем запятую после запятой
                }

                if (key != ' ' && key != ',' && key != '-')
                {
                    banOemMinus = true; // Запрещаем минус после символов
                    banSpacebar = false; // Разрешаем пробел после символа
                }
            }
        }
    }
    return res.Trim().Split(' ').Select(double.Parse).ToArray();
}

////Считает количество введенных положительных чисел
int Count(double[] array)
{
    int res = 0;
    foreach (double item in array)
    {
        if (item > 0)
            res++;
    }
    return res;
}

//Печатает одномерный массив
void Print1DArray(double[] array)
{
    Console.Write("Введены следующие числа: ");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine(array[array.Length - 1]);
}

//Основная программа
PrintInfo(
    "Вводите положительные и отрецательные цифры через пробел (можно вещественные разделенные запятой), по окончании введите Enter"
);
double[] array = InputData();
Print1DArray(array);
PrintInfo("Количество введеных положительных чисел: ", Count(array).ToString());