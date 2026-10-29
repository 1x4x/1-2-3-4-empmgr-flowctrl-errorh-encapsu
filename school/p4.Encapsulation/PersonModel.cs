using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace walter_practises.Encapsulation
{
    internal class PersonModel
    {
        private string firstname;
        public string FirstName 
        { 
            get { return firstname; } 
            set { firstname = value; } 
        }

        private string lastname;
        public string LastName
        {
            get { return lastname; }
            set { lastname = value; }
        }

        private string age;
        public int Age
        {
            get { return Convert.ToInt32(age); }
            set { age = value.ToString(); }
        }
        //public string V1 { get; }
        //public string V2 { get; }
        //public int V3 { get; }
        private int salary { get; }
        public PersonModel(string firstname, string lastname, int age)
        {
            FirstName = firstname;
            LastName = lastname;
            Age = age;
        }
        public override string ToString()
        {
            //Console.WriteLine($"{firstname}{lastname} is {age} years old.");
            return $"{firstname} {lastname} is {age} years old.";
            //return $"{FirstName} {LastName} {Age}";
        }   
    }
}
