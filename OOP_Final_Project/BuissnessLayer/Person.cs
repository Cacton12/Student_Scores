using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Final_Project
{
    public class Person
    {
        public string First_Name { get; set; } = string.Empty;
        public string Last_Name { get; set; } = string.Empty;

        public Person(string first_Name, string last_Name)
        {
            First_Name = first_Name;
            Last_Name = last_Name;
        }

        public override string? ToString()
        {
            return $"{First_Name} {Last_Name}";
        }
    }
}
