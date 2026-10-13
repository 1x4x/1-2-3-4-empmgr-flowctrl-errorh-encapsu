using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace walter_practises.Exceptions
{
    internal class ExceptionManager : Interface.IManager
    {
        public void Start()
        {
            Heading();

            Console.WriteLine("=== Start av programmet===");

            try
            {
                Console.WriteLine("Försöker läsa fil och räkna...");

                string path = Path.Combine(
                    AppDomain.CurrentDomain.BaseDirectory,
                    "numbers.txt");

                double result = ProcessFile(path);

                Console.WriteLine(
                    "\nResultat: {0:F2}",
                    result);

                Console.WriteLine("Beräkningen lyckades.");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(
                    "Filen hittades inte: " + ex.Message);
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine(
                    "Katalogen hittades inte: " + ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(
                    "Formatfel: " + ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(
                    "Kan inte dividera med noll: " + ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(
                    "Ogiltigt argument: " + ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(
                    "Ogiltig operation: " + ex.Message);
            }
            catch (IOException ex)
            {
                Console.WriteLine(
                    "Filfel: " + ex.Message);
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine(
                    "Åtkomst nekad: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(
                    "Ett oväntat fel inträffade: " + ex.Message);
            }
            finally
            {
                Console.WriteLine(
                    "Cleanup: Logging avslutat anrop.");
            }

            Console.WriteLine("Programmet avslutas.");
            Console.WriteLine("Tryck på valfri tangent för att avsluta.");
            Console.ReadKey();
        }
        public void Heading()
        {
            Console.WriteLine("=== Exceptions ===");
            Console.WriteLine("to make this run: (in visual studio on numbers.txt make sure copy if newer is selected to let that file be available for the program in the bin folder)");
        }

        static double ProcessFile(string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
            {
                throw new ArgumentException(
                    "Filnamn får inte vara tomt eller null.",
                    "fileName");
            }

            // StreamReader stängs automatiskt efter användning.
            using (StreamReader reader = new StreamReader(fileName))
            {
                string line = reader.ReadLine();

                if (line == null)
                {
                    throw new InvalidOperationException(
                        "Filen är tom");
                }

                int number;

                // Läs ett heltal med ett konsekvent format.
                if (!int.TryParse(
                    line,
                    NumberStyles.Integer,
                    CultureInfo.InvariantCulture,
                    out number))
                {
                    throw new FormatException(
                        "Filen innehåller inte ett giltigt heltal: '"
                        + line + "'");
                }

                if (number == 0)
                {
                    throw new DivideByZeroException(
                        "Talet i filen får inte vara noll");
                }

                return 100.0 / number;
            }
        }

    }
}
