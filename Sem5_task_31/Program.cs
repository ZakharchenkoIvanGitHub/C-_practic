//==========================================
//#31 Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
//Найдите сумму отрицательных и положительных элементов массива
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

//Универсальный метод генерауии и заполнения массива
int[] FillArray(int arrLen, int downBorder, int topBorder)
{
    int[] array = new int[arrLen];
    Random numSintezator = new Random();

    if (downBorder < topBorder)
    {
        for (int i = 0; i < arrLen; i++)
        {
            array[i] = numSintezator.Next(downBorder, topBorder + 1);
        }
    }
    return array;
}

//Печатает одномерный массив
void Print1DArray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine(array[array.Length - 1]);
}

int [] NegotivPositivSums(int[]arr) {
    int [] sums = new int [2];
    for (int i =0; i<arr.Length; i++){
        if (arr[i]>0){
            sums[0]+=arr[i];
        }
        else
        {sums[1]+=arr[i];}
    }
    return sums;
}
/* int arrayLength = ReadData("Введите длину массива" );
int arrayLength = ReadData("Введите длину массива" ); */


int [] inputArray = FillArray(12,-9,9);

Print1DArray(inputArray);

int [] sumArray = NegotivPositivSums(inputArray);

Print1DArray(sumArray);