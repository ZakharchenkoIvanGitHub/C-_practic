//==========================================
//#29 Напишите программу, которая задаёт массив
//из 8 элементов и выводит их на экран
//* Ввести с клавиатуры длину массива и диапазон значений элементов
//==========================================

Dictionary<string, int> ReadData(string greeting = "Введите данные")
//Получает строку заголовок
{
    Dictionary<string, int> dict = new Dictionary<string, int>(); //Создаем словарь

    //Выводим сообщение
    Console.WriteLine(greeting);

    Console.WriteLine("Введите длину массива");
    int.TryParse((Console.ReadLine() ?? "0"), out int lengh); // переводим в число
    dict.Add("lengh", lengh);

    Console.WriteLine("Введите начало диапазона");
    int.TryParse((Console.ReadLine() ?? "0"), out int start); // переводим в число
    dict.Add("start", start);

    Console.WriteLine("Введите конец диапазона");
    int.TryParse((Console.ReadLine() ?? "0"), out int finish); // переводим в число
    dict.Add("finish", finish);

    return dict;
}


//Генератор массива
int[] GenArray(Dictionary<string, int> dict)
{
    int[] array = new int[dict["lengh"]];
    Random ren = new Random();

    for (int i = 0; i < dict["lengh"]; i++)
    {
        array[i] = ren.Next(dict["start"], dict["finish"]+1);
    }
    return array;
}

//Вывод массива
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine(array[array.Length - 1]);
}

PrintArray(GenArray(ReadData()));