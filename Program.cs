// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Input numbers(with space): ");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = arr.Count(x => x > 0);
Console.WriteLine($"Amount of numbers > 0: {count}");


// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


double k1 = InputNum();

double b1 = InputNum();

double k2 = InputNum();

double b2 = InputNum();

double x = -(b1 - b2) / (k1 - k2);
double y = k1 * x + b1;

x = Math.Round(x, 3);
y = Math.Round(y, 3);

Console.WriteLine($"Point intersection: ({x};{y})");

double InputNum()
{
    Console.WriteLine("Input numbers in order k1, b1, k2, b2 ");
    bool isParsed = double.TryParse(Console.ReadLine(), out double num);
    if (isParsed)
    {
        return num;
    }
    else
    {
        Console.WriteLine("Wrong numbers");
        return -1;
    }
} 

