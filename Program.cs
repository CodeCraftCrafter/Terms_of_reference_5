using System;
using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder inputText = new StringBuilder();
        Console.WriteLine("Введите текст (введите 'end' для завершения ввода):");

        while (true)
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "end")
            {
                break;
            }
            inputText.Append(input + Environment.NewLine);
        }

        string finalText = inputText.ToString();
        Console.WriteLine($"Общее количество символов: {finalText.Length}");

        Console.WriteLine("Введите символ для поиска:");
        char searchCharacter = Console.ReadLine()[0];

        int count = 0;

        foreach (char c in finalText)
        {
            if (c == searchCharacter)
            {
                count++;
            }
        }

        Console.WriteLine($"Символ '{searchCharacter}' найден {count} раз(а) в введенном тексте.");
    }
}