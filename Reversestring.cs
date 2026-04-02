using System;
class Program
{
    static void Main()
    {
        string input ="winwire";
        char[] chars = input.ToCharArray();
        Array.Reverse(chars);
        string reversed = new string(chars);
        Console.WriteLine("original string: " + input);
        Console.WriteLine("Reversed string: " + reversed);
    }
}