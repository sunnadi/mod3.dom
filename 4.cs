using System;

public class NumberPrinter
{
    public void PrintPositiveNumbers(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
            return;

        int[] positiveNumbers = new int[numbers.Length];
        int count = 0;

        foreach (var number in numbers)
        {
            if (number > 0)
            {
                positiveNumbers[count] = number;
                count++;
            }
        }

        for (int i = 0; i < count - 1; i++)
        {
            for (int j = 0; j < count - 1 - i; j++)
            {
                if (positiveNumbers[j] > positiveNumbers[j + 1])
                {
                    int temp = positiveNumbers[j];
                    positiveNumbers[j] = positiveNumbers[j + 1];
                    positiveNumbers[j + 1] = temp;
                }
            }
        }

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(positiveNumbers[i]);
        }
    }
}

class Program
{
    static void Main()
    {
        var printer = new NumberPrinter();

        int[] numbers = { -2, 3, 0, 5, -1, 7 }; 
        printer.PrintPositiveNumbers(numbers);
    }
}

