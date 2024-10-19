using System;

public class NumberProcessor
{
    public void ProcessNumbers(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
            return;

        foreach (var number in numbers)
        {
            if (number > 0)
            {
                Console.WriteLine(number); 
            }
        }
    }
}
class Program
{
    static void Main()
    {
        var processor = new NumberProcessor();

        int[] numbers = { -2, 3, 0, 5, -1, 7 }; 
        processor.ProcessNumbers(numbers);
    }
}
