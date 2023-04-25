using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_AggegationAndContainment
{
    internal class SchoolProgram
    {
        //fields
        string _className;
        string _classNumber;
        string _roomNumber;
        Instructor _instructor; // Aggregation
        List<Student> _classRoster; // Containment

        //constructors
        public SchoolProgram(string className, string classNumber, string roomNumber, Instructor instructor)
        {
            _className = className;
            _classNumber = classNumber;
            _roomNumber = roomNumber;
            _instructor = instructor;
            _classRoster = new List<Student>();
        }

        //properties
        public string ClassName { get => _className; set => _className = value; }
        public string ClassNumber { get => _classNumber; set => _classNumber = value; }
        public string RoomNumber { get => _roomNumber; set => _roomNumber = value; }
        internal Instructor Instructor { get => _instructor; set => _instructor = value; }
        public List<Student> ClassRoster { get => _classRoster; }

        //Methods
        public void AddStudent(Student student)
        {
            _classRoster.Add(student);
        }

        public void AddStudent(string FirstName, string LastName, int CsiGrade, int GenEdGrade)
        {
            Student student = new Student(FirstName, LastName, CsiGrade, GenEdGrade);
            _classRoster.Add(student);
        }

        public override string ToString()
        {
            return $"{ClassName} - {ClassNumber}: Room: {RoomNumber} - Instructor: {Instructor.FirstName + " " + Instructor.LastName} - Number of Students: {ClassRoster.Count}";
        }

    }//end of class

}//end of namespace
