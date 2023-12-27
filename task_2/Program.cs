/*Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.*/

using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите значение n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите значение m: ");
        int m = Convert.ToInt32(Console.ReadLine());

        int result = AckermannFunction(n, m);
        Console.WriteLine($"Значение функции Аккермана для ({n}, {m}) равно: {result}");
    }

    static int AckermannFunction(int n, int m)
    {
        if (n == 0)
            return m + 1;
        else if (n > 0 && m == 0)
            return AckermannFunction(n - 1, 1);
        else if (n > 0 && m > 0)
            return AckermannFunction(n - 1, AckermannFunction(n, m - 1));
        else
            throw new ArgumentException("Некорректные значения n и m.");
    }
}