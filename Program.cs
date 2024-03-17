using System;
using System.Xml.Linq;

class Program
{
    static void Main()
    {
                int[] array = new int[50];

               for (int i = 0; i < 50; i++)
        {
            array[i] = 2 + i * 2;
        }
        Console.WriteLine("Начало вывода массива:");
        foreach (int element in array)
        {
            Console.WriteLine("Element: " + element);
        }
    }
}