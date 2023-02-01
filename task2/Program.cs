// Задача 43: Напишите программу, которая найдёт точку 
// пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void Function(double k1, double k2, double b1, double b2)
{
    double x;
    double y;
    x = (b1 - b2) / (k2 - k1);
    y = 9 * x + 4;
    System.Console.WriteLine(x);
    System.Console.WriteLine(y);
}

double b1 = 2, k1 = 5, b2 = 4, k2 = 9;
Function(k1,k2,b1,b2);