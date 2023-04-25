using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_AggegationAndContainment
{
    internal class Instructor
    {
        //fields
        string _firstName;
        string _lastName;

        //constructors
        public Instructor(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }

        //properties
        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }

        public override string ToString()
        {
            return $"Instructor: {FirstName} {LastName}";
        }


    }//end class

}//end namespace
