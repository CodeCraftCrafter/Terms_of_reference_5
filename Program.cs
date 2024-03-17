using System;

class Program
{
    static void Main()
    {
        int[] numbers = new int[50];
        Random random = new Random();
        int evenCount = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(1, 101);

            if (numbers[i] % 2 == 0)
            {
                evenCount++;
            }
        }
        Console.WriteLine("Сгенерированные числа:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine("Количество четных чисел: " + evenCount);
    }
}