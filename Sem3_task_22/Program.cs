//==========================================
//#22 Напишите программу, которая принимает на вход
//число (N) и выдаёт таблицу квадратов чисел от 1 до N.
//==========================================

int ReadData(string greeting = "Введите данные")
{
    //Выводим сообщение
    Console.WriteLine(greeting);
    //считываем число
    return int.Parse(Console.ReadLine() ?? "0");
}


// string LineNumbers(int numberN){
//     int i=1;
//     string outLine = string.Empty;
//     while(i<numberN){
//         outLine = outLine + i +"\t";
//         i++;
//     }
//     outLine = outLine + i;
//     return outLine;
// }

// комментарий
string Line(int numberN, int pow){

        int i=1;
    string outLine = string.Empty;
    while(i<numberN){
        outLine = outLine + Math.Pow(i,pow) +"\t";
        i++;
    }
    outLine = outLine + Math.Pow(i,pow);
    return outLine;
    
}


void PrintResult(string line)
{
    Console.WriteLine(line);
}


int num = ReadData("Введите N: ");

PrintResult(Line(num,1));
PrintResult(Line(num,2));


