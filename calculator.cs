using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("enter second number: ");
        int num2 = int.Parse(Console.ReadLine());
        Console.Write("enter operator (+,-,*,/):");
        char op = Convert.ToChar(Console.ReadLine());
        int result = 0;
        switch (op)
        {
            case '+':
                result = num1 + num2;
                Console.WriteLine("Result: " + result);
                break;

            case '-':
                result = num1 - num2;
                Console.WriteLine("Result: " + result);
                break;
            case '*':
                result = num1 * num2;
                Console.WriteLine("Result: " + result);
                break;
            case '/':
                if (num2 !=0)
                {
                    result = num1 / num2;
                    Console.WriteLine("Result:" + result);
                }
                else
                {
                    Console.WriteLine("Division by zero is not allowed");
                }
                break;
            default:
               Console.WriteLine("invalid operator");
               break;            
        }
    }
}