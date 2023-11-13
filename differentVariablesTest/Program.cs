using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Numerics;

namespace differentVariablesTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // oppgave 1

            int numberVar = 3;
            double doubleVar = 4.22;
            char charVar = 'I';
            string stringVar = "Testing Strings";
            bool boolVar = true;
            long longVar = 33435342;
            decimal decimalVar = 312.233m;
            float floatVar = 23123.232324f;
            Console.WriteLine($"Write something and hit enter to start testing input");
            var inputVar = Console.ReadLine();
            Console.WriteLine($"what you wrote is the input: {inputVar}");
            Console.WriteLine($"testing number:{numberVar}");
            Console.WriteLine($"testing  double: {doubleVar}");
            Console.WriteLine($"testing char:{charVar}");
            Console.WriteLine($"testing  string: {stringVar}");
            Console.WriteLine($"testing bool:{boolVar}");
            Console.WriteLine($"testing long: {longVar}");
            Console.WriteLine($"testing float :{floatVar}");
            Console.WriteLine($"testing decimal: {decimalVar}");

            // oppgave 2

            int a = 5;
            decimal b = 3.0m;
            decimal sum = a + b;

            Console.WriteLine($"if the int is {a} and the decimal is {b} the total can show as a decimal too, and it becomes = {sum}");
        }
    }
}