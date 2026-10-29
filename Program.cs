using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace walter_practises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // make it easier for the teacher to test the program
            // by allowing them to select the project to run

            
            // Uncomment the project you want to run:
            // ----------------------------------------

            //runProject(Exercise.EmployeeManager);
            //runProject(Exercise.LoopsAndStrings);
            //runProject(Exercise.Exceptions);
            //runExercise(Exercise.FizzBuzz);
            //runExercise(Exercise.MaximumNumber);
            //runExercise(Exercise.SortTwoNumbers);
            runExercise(Exercise.Encapsulation);
        }

        static void runExercise(Exercise exercise)
        {
            // school excercises
            if (exercise == Exercise.EmployeeManager) { new school.p1.EmployeeManager.EmployeeManager().Start(); }
            if (exercise == Exercise.LoopsAndStrings) { new school.p2.LoopsAndStrings.LoopsAndStringsManager().Start(); }
            if (exercise == Exercise.Exceptions) { new school.p3.Exceptions.ExceptionManager().Start(); }
            if (exercise == Exercise.Encapsulation) { new school.p4.Encapsulation.EncapsulationManager().Start(); }

            // kattis.com excercises
            if (exercise == Exercise.FizzBuzz) { new kattis.k1000.FizzBuzzManager().Start(); }
            if (exercise == Exercise.MaximumNumber) { new kattis.k1001.MaximumNumberManager().Start(); }
            if (exercise == Exercise.SortTwoNumbers) { new kattis.k1002.SortTwoNumbersManager().Start(); }    
        }

        // Add more projects here as needed
        enum Exercise
        {
            EmployeeManager = 1,
            LoopsAndStrings = 2,
            Exceptions = 3,
            Encapsulation = 4,
            Garage = 5,
            FizzBuzz = 1000,
            MaximumNumber = 1001,
            SortTwoNumbers = 1002           
        }
    }
}
