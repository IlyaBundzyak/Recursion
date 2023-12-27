/*Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. 
Использовать рекурсию, не использовать циклы.*/

using System;
class Program
{
    static void Main()
    {
        int[] array = { 3, 9, 5, 32, -7, 68 };

        PrintArrayFromEnd(array, array.Length - 1);


        static void PrintArrayFromEnd(int[] arr, int i)
        {
            if (i >= 0)
            {
                Console.WriteLine(arr[i]);
                PrintArrayFromEnd(arr, i - 1);
            }
        }
    }

}