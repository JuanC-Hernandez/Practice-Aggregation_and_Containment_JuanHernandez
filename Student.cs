using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Aggregation_and_Containment_JuanHernandez
{
    internal class Student
    {
        // Fields
        string _firstName;
        string _lastName;
        int _csiGrade;
        int _genEdGrade;

        // Properties
        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public int CsiGrade { get => _csiGrade; set => _csiGrade = value; }
        public int GenEdGrade { get => _genEdGrade; set => _genEdGrade = value; }

        // Constructor
        public Student(string firstname, string lastname, int csigrade, int genedgrade) 
        { 
            FirstName = firstname;
            LastName = lastname;
            CsiGrade = csigrade;
            GenEdGrade = genedgrade;
        }

        // Override
        public override string ToString()
        {
            return $"{FirstName} {LastName} - CSI Grade: {CsiGrade} - GenEd Grade: {GenEdGrade}";
        }
    }
}
