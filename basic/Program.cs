using System;
using System.Globalization;

namespace csharp_coding
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = 0.00;
            Console.Write("Type a number: ");
            try {
                n = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            } catch (System.FormatException) {
                Console.WriteLine("You have to put a number, not a string.");
            } finally {
                Console.WriteLine(n.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
