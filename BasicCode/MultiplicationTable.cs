namespace BasicCode
{
    internal class MultiplicationTable
    {
        public static void CountMultiplication()
        {
            // En array som innehåller multiplikationstabellens tal (1 till 12)
            int[] multiNumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            // Variabler för att hålla koll på antal rätta och felaktiga svar
            int correctAnswers = 0;
            int failedAnswers = 0;

            // Beräknar det totala antalet frågor (13 frågor per tal från 1 till 12)
            int totalQuestions = multiNumbers.Length * 13;

            // Yttre loop som går igenom varje tal i multiplikationstabellen
            foreach (int i in multiNumbers)
            {
                // Inre loop som går igenom varje multiplikation från 0 till 12 för varje tal
                for (int j = 0; j <= 12; j++)
                {
                    // Beräknar nuvarande frågenummer genom att addera rätta och felaktiga svar
                    int questionNumber = correctAnswers + failedAnswers + 1;

                    // Visar nuvarande fråga, antal rätta och felaktiga svar
                    Console.WriteLine("Fråga:\t" + questionNumber + " av " + totalQuestions);
                    Console.WriteLine("Antal rätt:\t" + correctAnswers);
                    Console.WriteLine("Antal fel:\t" + failedAnswers);
                    Console.WriteLine("Hur mycket är:\t" + i + " x " + j + " ? ");

                    // Variabel för att hålla användarens svar
                    int answer;

                    // Loop för att säkerställa att inmatningen är ett giltigt heltal
                    while (!int.TryParse(Console.ReadLine(), out answer))
                    {
                        // Om inmatningen är ogiltig (inte ett heltal) visas ett felmeddelande i röd färg
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ogiltig inmatning, vänligen mata in ett heltal.");
                        Console.ResetColor();
                    }

                    // Kontrollera om användarens svar är korrekt
                    if (answer == i * j)
                    {
                        // Om svaret är korrekt, visa ett meddelande i grönt och ökar poängen
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Rätt! Bra jobbat!");
                        correctAnswers++;
                        Thread.Sleep(1000);
                        Console.Clear();
                        Console.ResetColor();

                    }

                    else
                    {
                        // Om svaret är fel, ge användaren en ny chans (andra försöket)
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Fel, försök igen");
                        Console.ResetColor();

                        // Variabel för andra försöket
                        int secondTry;

                        // Loop för att säkerställa att inmatningen är ett giltigt heltal vid andra försöket
                        while (!int.TryParse(Console.ReadLine(), out secondTry))
                        {
                            // Om inmatningen är ogiltig (inte ett heltal) visas ett felmeddelande i röd färg
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Ogiltig inmatning, vänligen mata in ett heltal.");
                            Console.ResetColor();
                        }

                        // Kontrollera om andra försöket är korrekt
                        if (secondTry == i * j)
                        {
                            // Om andra försöket är korrekt, visa ett meddelande i grönt och öka poängen
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Rätt! Bra jobbat!");
                            correctAnswers++;
                            Thread.Sleep(1000);
                            Console.ResetColor();
                        }

                        else
                        {
                            // Om andra försöket också är fel, visa ett meddelande i röd färg och öka antalet felaktiga svar
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Fel igen, försök lösa nästa istället!");
                            failedAnswers++;
                            Console.ResetColor();

                        }
                    }
                }
            }
            // Beräknar totalt antal besvarade frågor
            int totalAnswered = correctAnswers + failedAnswers;

            // Beräknar procentandelen rätta svar
            double percentageCorrect = (double)correctAnswers / totalAnswered * 100;

            // Visar slutresultatet
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nSpelet är slut!");
            Console.WriteLine("Totalt antal frågor: " + totalQuestions);
            Console.WriteLine("Antal rätt: " + correctAnswers);
            Console.WriteLine("Antal fel: " + failedAnswers);
            Console.WriteLine("Du fick " + Math.Round(percentageCorrect, 2) + "% rätt.");
            Console.ResetColor();
        }
    }
}
