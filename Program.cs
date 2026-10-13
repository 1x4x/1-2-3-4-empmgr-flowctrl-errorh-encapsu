using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using walter_practises.Exceptions;
using walter_practises.FizzBuzz;

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
            runExercise(Exercise.SortTwoNumbers);
        }

        static void runExercise(Exercise exercise)
        {
            // school excercises
            if (exercise == Exercise.EmployeeManager) { new EmployeeManager.EmployeeManager().Start(); }
            if (exercise == Exercise.LoopsAndStrings) { new LoopsAndStrings.LoopsAndStringsManager().Start(); }
            if (exercise == Exercise.Exceptions) { new ExceptionManager().Start(); }

            // kattis.com excercises
            if (exercise == Exercise.FizzBuzz) { new FizzBuzzManager().Start(); }
            if (exercise == Exercise.MaximumNumber) { new MaximumNumber.MaximumNumberManager().Start(); }
            if (exercise == Exercise.SortTwoNumbers) { new SortTwoNumbers.SortTwoNumbersManager().Start(); }    
        }

        // Add more projects here as needed
        enum Exercise
        {
            EmployeeManager = 1,
            LoopsAndStrings = 2,
            Exceptions = 3,
            FizzBuzz = 1000,
            MaximumNumber = 1001,
            SortTwoNumbers = 1002
            
        }
    }
}
