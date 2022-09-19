//==========================================
//#43   Найдите площадь треугольника образованного пересечением 3 прямых
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

//выводит строку на печать
void PrintInfo(string line1, string line2 = "")
{
    Console.WriteLine(line1 + line2);
}

// Ищет точку пересечения
double[] PointFind(double b1, double k1, double b2, double k2)
{
    double[] xy = new double[2];
    xy[0] = (b2 - b1) / (k1 - k2);
    xy[1] = k1 * xy[0] + b1;
    return xy;
}
// Ищет площадь треугольника вариант 1
double AreaTriangle(double b1, double k1, double b2, double k2, double b3, double k3)
{
    double[] point1 = PointFind(b1,  k1,  b2,  k2);//ищем координаты точек пересечения
    double[] point2 = PointFind(b2,  k2,  b3,  k3);
    double[] point3 = PointFind(b1,  k1,  b3,  k3);

    return 0.5*Math.Abs((point2[0]-point1[0])*(point3[1]-point1[1])-(point3[0]-point1[0])*(point2[1]-point1[1]));
}

// Ищет площадь треугольника вариант 2 по формуле Герона
double AreaTriangleGeron(double b1, double k1, double b2, double k2, double b3, double k3)
{
    double[] point1 = PointFind(b1,  k1,  b2,  k2);//ищем координаты точек пересечения
    double[] point2 = PointFind(b2,  k2,  b3,  k3);
    double[] point3 = PointFind(b1,  k1,  b3,  k3);

    double line1 = SegmentLength(point1,point2);// ищем длины отрезков
    double line2 = SegmentLength(point2,point3);
    double line3 = SegmentLength(point1,point3);
    
    double semPer = 0.5*(line1+line2+line3); // полупериметр

    return Math.Sqrt(semPer*(semPer-line1)*(semPer-line2)*(semPer-line3)); 
}

//Ищет длину отрезка
double SegmentLength(double [] point1,double[] point2){
return Math.Sqrt(Math.Pow((point1[0]-point2[0]),2)+Math.Pow((point1[1]-point2[1]),2));
}

//Проверка на пересечение
bool InterCheck(int k1, int k2, int k3)
{
    if ((k1 == k2) || (k2 == k3) || (k3 == k1))
        return false;
    else
        return true;
}

//Основная программа
PrintInfo(
    "Введите значения b1, k1, b2,  k2, b3 и k3 уравнений \ny = k1 * x + b1, y = k2 * x + b2, y = k3 * x + b3 \nи программа найдет площадь треугольника образованного пересечением 3 прямых"
);
int b1 = ReadData("Введите b1");
int k1 = ReadData("Введите k1");
int b2 = ReadData("Введите b2");
int k2 = ReadData("Введите k2");
int b3 = ReadData("Введите b3");
int k3 = ReadData("Введите k3");

if (InterCheck(k1, k2, k3))
{
    
    PrintInfo("Площадь треугольника вариант 1 ", $"S = {AreaTriangle( b1,  k1,  b2,  k2,  b3,  k3)}");
    PrintInfo("Площадь треугольника вариант 2 по формуле Герона ", $"S = {AreaTriangleGeron( b1,  k1,  b2,  k2,  b3,  k3)}");
}
else
{
    PrintInfo("Линии не пересекаются");
}
