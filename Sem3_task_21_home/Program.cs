//==========================================
//#21 Напишите программу, которая принимает на вход координаты двух
//точек и находит расстояние между ними в 3D пространстве.
//==========================================

string ReadData(string greeting = "Введите данные")
{
    //Выводим сообщение
    Console.WriteLine(greeting);
    //считываем строку
    return Console.ReadLine() ?? "0";
}

//Парсер введенных данных, на выходе массив координат [x1,y1,z1,x2,y2,z2]
int[] Parser(string line)
{
    int[] intArray = new int[6]; //соззаем массив
    int bracket1 = line.IndexOf("(") + 1; //Определяем местонахождение скобок
    int bracket2 = line.IndexOf(")");
    int bracket3 = line.LastIndexOf("(") + 1;
    int bracket4 = line.LastIndexOf(")");
    string[] strArray = ( //переносим координаты в массив строк
        line.Substring(bracket1, bracket2 - bracket1)
        + ","
        + line.Substring(bracket3, bracket4 - bracket3)
    ).Split(",");

    int i = 0;
    foreach (string str in strArray)
    { //парсим в массив int
        intArray[i] = int.Parse(str);
        i++;
    }

    return intArray;
}

//Вычисляет расстояние между точками
//Принимает массив координат [x1,y1,z1,x2,y2,z2]
double Calculate(int[] array)
{
    return Math.Sqrt(
        Math.Pow((array[0] - array[3]), 2)
            + Math.Pow((array[1] - array[4]), 2)
            + Math.Pow((array[2] - array[5]), 2)
    );
}

//выводит строку на печать
void PrintResult(string line)
{
    Console.WriteLine(line);
}

//Основная программа
PrintResult(
    "Введите координаты двух точек и программа найдет расстояние между ними в 3D пространстве "
);

string line = ReadData("Введите координаты в формате A(x1,y1,z1),B(x2,y2,z2) :");
int[] coordinates = new int[6];
try
{
    coordinates = Parser(line);
}
catch (ArgumentOutOfRangeException)
{
    ReadData("Ошибка! Неверный формат введенных данных");
    Environment.Exit(0);
}
catch (FormatException)
{
    ReadData("Ошибка! Указывайте координаты цифрами");
    Environment.Exit(0);
}


PrintResult("расстояние между точками = " + Math.Round(Calculate(coordinates), 2));

