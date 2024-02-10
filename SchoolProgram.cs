using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Aggregation_and_Containment_JuanHernandez
{
    internal class SchoolProgram
    {
        // fields
        string _className;
        string _classNumber;
        string _roomNumber;
        Instructor _instructor; // aggregation
        List <Student> _classRoster; // containment

        // properties
        public string ClassName { get => _className; set => _className = value; }
        public List<Student> ClassRoster { get => _classRoster; }
        public string ClassNumber { get => _classNumber; set => _classNumber = value; }
        public string RoomNumber { get => _roomNumber; set => _roomNumber = value; }
        internal Instructor Instructor { get => _instructor; set => _instructor = value; }


        // constructor
        public SchoolProgram(string className, string classNumber, string roomNumber, Instructor instructor)
        {
            //List<Student> _classRoster = new List<Student>();
            List<Student> ClassRoster = new List<Student>();    
            ClassName = className;
            ClassNumber = classNumber;
            RoomNumber = roomNumber;
            Instructor = instructor;
            
                      
        }

        // Methods
        public void AddStudent(Student student)
        {
            ClassRoster.Add(student);
        }

        public void AddStudent(string firstName, string lastName, int csiGrade, int genEdGrade)
        {
            Student student = new Student(firstName, lastName, csiGrade, genEdGrade);
        }
        public override string ToString()
        {
            return $"{ClassName} {ClassNumber} - Room: {RoomNumber} - Instructor: {Instructor} - Number of Students:"; //  {_classRoster.Count} doesnt work
        }
    }
}
