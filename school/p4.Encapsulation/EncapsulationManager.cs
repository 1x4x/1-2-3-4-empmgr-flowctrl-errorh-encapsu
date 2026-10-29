using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using walter_practises.Encapsulation;

namespace walter_practises.school.p4.Encapsulation
{
    internal class EncapsulationManager : walter_practises.Interface.IManager
    {
        public void Heading()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("https://open.kattis.com/problems/encapsulation");
            Console.ResetColor();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("=== Encapsulation ===");
            Console.WriteLine("This exercise demonstrates the concept of encapsulation in object-oriented programming.");
            Console.ResetColor();
        }

        public void Start()
        {
            Heading();
            // Implementation of the encapsulation exercise goes here



            var lines = 1;
            var persons = new List<PersonModel>();
            for (int i = 0; i < lines; i++)
            {
                // get info from console input
                //var cmdArgs = Console.ReadLine().Split();
                //var personModel = new PersonModel(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2]));


                // get info from list instead of console input
                var list = getInfoFromList();
                foreach (var item in list)
                {
                    var personModel = item;
                    persons.Add(personModel);
                }
            }
            persons.OrderBy(p => p.FirstName)
            .ThenBy(p => p.Age)
            .ToList()
            .ForEach(p => Console.WriteLine(p.ToString()));

            //foreach (var item in persons)
            //{
            //    Console.WriteLine($"{item.FirstName}{item.LastName} is {item.Age} years old.");
            //}
        }

        private List<PersonModel> getInfoFromList()
        {
            var list = new List<PersonModel>();
            list.Add(new PersonModel("Anna", "Persson", 65));
            list.Add(new PersonModel("Anna", "Andersson", 34));
            list.Add(new PersonModel("Johanna", "Eriksson", 57));
            list.Add(new PersonModel("Johanna", "Svensson", 27));
            list.Add(new PersonModel("Erika", "Samuelsson", 35));
            return list;
        }
    }
}