using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCode
{
    internal class MultiplicationRandom
    {
        public static void RandomMultiplicationNumbers()
        {
            int correctAnswers = 0;
            int failedAnswers = 0;
            int totalQuestions = 50;
            int questionCount = 0;

            while (questionCount < totalQuestions)
            {
                Random rnd = new Random();
                int x = rnd.Next(12);
                int y = rnd.Next(12);

                Console.WriteLine("Antal rätt:\t" + correctAnswers);
                Console.WriteLine("Antal fel:\t" + failedAnswers);
                Console.WriteLine();
                Console.WriteLine("Hur mycket är " + x + " x " + y + "?");
                int answer;

                while (!int.TryParse(Console.ReadLine(), out answer))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ogiltig inmatning, vänligen mata in ett heltal.");
                    Console.ResetColor();
                }

                if (answer == x * y)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Rätt! Poäng till dig!");
                    correctAnswers++;
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Tyvärr fel, försök igen!");
                    failedAnswers++;
                    Console.ResetColor();
                }

                questionCount++;
                Thread.Sleep(1000);

                Console.Clear();

            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            double correctPercentage = ((double)correctAnswers / totalQuestions) * 100;
            Console.WriteLine("Spelet är slut!");
            Console.WriteLine("Du svarade rätt på " + correctAnswers + " av " + totalQuestions + " frågor.");
            Console.WriteLine("Detta motsvarar " + correctPercentage.ToString("0.00") + "%.");
            Console.ResetColor();
        }
    }
}
