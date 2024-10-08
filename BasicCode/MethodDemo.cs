using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCode
{
    internal class MethodDemo
    {
        static void GetName()
        {
            Console.WriteLine("Hello Robin");
            Thread.Sleep(1000);
        }

        static void GetNumbersDivided()
        {
            Console.WriteLine("Give me a number: ");
            string firstNumber = Console.ReadLine();
            Console.WriteLine("Give me a second number: ");
            string secondNumber = Console.ReadLine();

            double firstNumberD = double.Parse(firstNumber);
            double secondNumberD = double.Parse(secondNumber);

            double result = firstNumberD / secondNumberD;
            Console.WriteLine("The first number divided by the second are: " + result);

            int numberOfDecimals = CountDecimals(result);
            Console.WriteLine("And the total number of deciamls are: " + numberOfDecimals);
        }

        static int CountDecimals(double result)
        {
            string numStr = result.ToString();

            if (numStr.Contains(','))
            {
                string[] parts = numStr.Split(',');

                return parts[1].Length;
            }

            return 0;
        }
    }
}
