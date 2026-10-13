using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace walter_practises.LoopsAndStrings
{
    internal class LoopsAndStringsManager : Interface.IManager
    {
        public void Start()
        {
            // Variabel som bestämmer om programmet ska fortsätta köras.
            bool isRunning = true;

            // Huvudloopen håller programmet igång tills användaren väljer 0.
            while (isRunning)
            {
                // Huvudmenyn visas varje gång loopen börjar om.
                Console.WriteLine();
                Console.WriteLine("========================================");
                Console.WriteLine("          HUVUDMENY");
                Console.WriteLine("========================================");
                Console.WriteLine("Du har kommit till huvudmenyn.");
                Console.WriteLine("Skriv en siffra för att testa de olika funktionerna.");
                Console.WriteLine();
                Console.WriteLine("1. Ungdom eller pensionär");
                Console.WriteLine("2. Helt sällskap - räkna ut biopris");
                Console.WriteLine("3. Upprepa text tio gånger");
                Console.WriteLine("4. Det tredje ordet");
                Console.WriteLine("0. Avsluta programmet");
                Console.WriteLine();

                Console.Write("Ditt val: ");
                string choice = Console.ReadLine();

                // Switch används för att välja vilken funktion användaren vill köra.
                switch (choice)
                {
                    case "0":
                        // Ändrar boolen till false så att while-loopen avslutas.
                        isRunning = false;
                        Console.WriteLine("Programmet avslutas...");
                        break;

                    case "1":
                        // Kör funktionen som räknar ut pris baserat på ålder.
                        CalculateTicketPrice();
                        break;

                    case "2":
                        // Kör funktionen som räknar ut pris för ett helt sällskap.
                        CalculateGroupPrice();
                        break;

                    case "3":
                        // Kör funktionen som skriver ut text tio gånger.
                        RepeatTextTenTimes();
                        break;

                    case "4":
                        // Kör funktionen som hittar det tredje ordet.
                        FindThirdWord();
                        break;

                    default:
                        // Om användaren skriver något annat än alternativen ovan.
                        Console.WriteLine("Felaktig input. Välj ett av alternativen 0-4.");
                        break;
                }
            }
        }
        public void Heading()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine();
            Console.WriteLine("=== LOOPS AND STRINGS ===");
            Console.ResetColor();
            
        }
        
        
        // ============================================================
        // MENYVAL 1 - UNGDOM ELLER PENSIONÄR
        // ============================================================

        static void CalculateTicketPrice()
        {
            Console.WriteLine();
            Console.WriteLine("--- Ungdom eller pensionär ---");

            // Vi använder en separat metod för att läsa in en giltig ålder.
            int age = ReadAge();

            // Barn under 5 år går gratis.
            if (age < 5)
            {
                Console.WriteLine("Gratis: 0kr");
            }
            // Personen är ungdom om personen är under 20 år.
            else if (age < 20)
            {
                Console.WriteLine("Ungdomspris: 80kr");
            }
            // Pensionärer över 100 år går gratis.
            else if (age > 100)
            {
                Console.WriteLine("Gratis: 0kr");
            }
            // Personen är pensionär om personen är över 64 år.
            else if (age > 64)
            {
                Console.WriteLine("Pensionärspris: 90kr");
            }
            // Alla andra betalar standardpris.
            else
            {
                Console.WriteLine("Standardpris: 120kr");
            }
        }


        // ============================================================
        // MENYVAL 2 - HELT SÄLLSKAP
        // ============================================================

        static void CalculateGroupPrice()
        {
            Console.WriteLine();
            Console.WriteLine("--- Beräkna pris för ett helt sällskap ---");

            // Frågar hur många personer som ska gå på bio.
            int numberOfPeople = ReadPositiveInteger(
                "Hur många personer är ni? "
            );

            int totalCost = 0;

            // Loopar igenom alla personer i sällskapet.
            for (int i = 1; i <= numberOfPeople; i++)
            {
                Console.Write($"Ange ålder för person {i}: ");

                int age = ReadAge();

                // Räknar ut priset för personen.
                int price = GetTicketPrice(age);

                // Lägger personens pris till totalkostnaden.
                totalCost += price;
            }

            // Skriver ut sammanfattningen.
            Console.WriteLine();
            Console.WriteLine("--- Sammanfattning ---");
            Console.WriteLine($"Antal personer: {numberOfPeople}");
            Console.WriteLine($"Totalkostnad: {totalCost}kr");
        }


        // ============================================================
        // HJÄLPMETOD - RÄKNA UT BILJETTPRIS
        // ============================================================

        static int GetTicketPrice(int age)
        {
            // Barn under 5 år går gratis.
            if (age < 5)
            {
                return 0;
            }

            // Ungdom under 20 år betalar 80 kr.
            if (age < 20)
            {
                return 80;
            }

            // Pensionärer över 100 år går gratis.
            if (age > 100)
            {
                return 0;
            }

            // Pensionärer över 64 år betalar 90 kr.
            if (age > 64)
            {
                return 90;
            }

            // Alla andra betalar 120 kr.
            return 120;
        }


        // ============================================================
        // MENYVAL 3 - UPPREPA TEXT TIO GÅNGER
        // ============================================================

        static void RepeatTextTenTimes()
        {
            Console.WriteLine();
            Console.WriteLine("--- Upprepa text tio gånger ---");

            Console.Write("Skriv en text: ");
            string input = Console.ReadLine();

            // Kontrollera att användaren faktiskt skrev något.
            while (string.IsNullOrWhiteSpace(input))
            {
                Console.Write("Du måste skriva något. Försök igen: ");
                input = Console.ReadLine();
            }

            Console.WriteLine();

            // For-loopen körs exakt tio gånger.
            for (int i = 1; i <= 10; i++)
            {
                // Skriver ut texten utan radbrytning.
                Console.Write($"{i}. {input}");

                // Lägger till mellanslag mellan varje text.
                if (i < 10)
                {
                    Console.Write(", ");
                }
            }

            Console.WriteLine();
        }


        // ============================================================
        // MENYVAL 4 - DET TREDJE ORDET
        // ============================================================

        static void FindThirdWord()
        {
            Console.WriteLine();
            Console.WriteLine("--- Det tredje ordet ---");

            Console.Write("Skriv en mening med minst 3 ord: ");
            string input = Console.ReadLine();

            // Fortsätter fråga tills användaren skriver minst tre ord.
            while (true)
            {
                // Split delar upp meningen vid mellanslag.
                // RemoveEmptyEntries gör att flera mellanslag i rad ignoreras.
                string[] words = input.Split(
                    new char[] { ' ' },
                    StringSplitOptions.RemoveEmptyEntries
                );

                // Vi behöver minst tre ord för att kunna hitta ord nummer tre.
                if (words.Length >= 3)
                {
                    // Index 2 är det tredje ordet eftersom array-index börjar på 0.
                    Console.WriteLine($"Det tredje ordet är: {words[2]}");
                    break;
                }

                Console.WriteLine("Du måste skriva minst tre ord.");
                Console.Write("Försök igen: ");
                input = Console.ReadLine();
            }
        }


        // ============================================================
        // HJÄLPMETOD - LÄS IN ÅLDER
        // ============================================================

        static int ReadAge()
        {
            while (true)
            {
                Console.Write("Ange ålder: ");
                string input = Console.ReadLine();

                // TryParse försöker konvertera texten till ett heltal.
                // Om användaren exempelvis skriver "abc" kraschar inte programmet.
                if (int.TryParse(input, out int age))
                {
                    // Åldern måste vara 0 eller högre.
                    if (age >= 0)
                    {
                        return age;
                    }
                }

                Console.WriteLine("Felaktig ålder. Ange ett heltal som är 0 eller högre.");
            }
        }


        // ============================================================
        // HJÄLPMETOD - LÄS IN POSITIVT HELTAL
        // ============================================================

        static int ReadPositiveInteger(string message)
        {
            while (true)
            {
                Console.Write(message);
                string input = Console.ReadLine();

                // TryParse kontrollerar att input faktiskt är ett heltal.
                if (int.TryParse(input, out int number))
                {
                    // Antalet personer måste vara större än 0.
                    if (number > 0)
                    {
                        return number;
                    }
                }

                Console.WriteLine("Felaktig input. Ange ett heltal större än 0.");
            }
        }
    }
}
