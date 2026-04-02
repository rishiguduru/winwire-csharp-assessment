using System;
class Program
{
    static void Main()
    {
        int[] numbers = { 1,2,3,4,5,6 };
        int sum = 0;
        foreach (int num in numbers)
        {
            if (num % 2 == 0)
            {
                sum += num;
            }
        }
        Console.WriteLine("sum of even numbers: " + sum);
    }
}