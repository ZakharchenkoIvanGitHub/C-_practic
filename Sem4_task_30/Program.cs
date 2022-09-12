//==========================================
//#30 Напишите программу, которая выводит массив из 8 элементов,
//заполненный нулями и единицами в случайном порядке.
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

//Генератор массива
int[] GenArray(int arrLen)
{
    int[] array = new int[arrLen];
    Random ren = new Random();

    for (int i = 0; i < arrLen; i++)
    {
        array[i] = ren.Next(0, 2);
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