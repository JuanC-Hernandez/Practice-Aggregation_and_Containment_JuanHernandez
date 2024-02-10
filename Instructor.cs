using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Aggregation_and_Containment_JuanHernandez
{
    internal class Instructor
    {
        // Fields
        string _firstName;
        string _lastName;

        // Properties
        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }

        // Constructor
        public Instructor(string firstname, string lastname) 
        { 
            FirstName = firstname;
            LastName = lastname;
        }

        // Override
        public override string ToString()
        {
            return $"Instructor {FirstName} {LastName}";
        }
    }
}
