using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_AggegationAndContainment
{
    internal class Student
    {
        //Fields
        string _firstName;
        string _lastName;
        int _csiGrade;
        int _genEdGrade;

        //Constructor
        public Student(string firstName, string lastName, int csiGrade, int genEdGrade)
        {
            _firstName = firstName;
            _lastName = lastName;
            _csiGrade = csiGrade;
            _genEdGrade = genEdGrade;
        }

        //Property
        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public int CsiGrade { get => _csiGrade; set => _csiGrade = value; }
        public int GenEdGrade { get => _genEdGrade; set => _genEdGrade = value; }

        public override string ToString()
        {
            return $"{FirstName} {LastName} - CSI Grade: {CsiGrade} - GenEd Grade: {GenEdGrade}";
        }


    }//end of class

}//end of namespace
