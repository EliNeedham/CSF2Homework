using System;

namespace ClassesLibrary
{
    public class Student 
    {
        //add a class that represents teh real world object indicated in the problem. makes sure to include all fields, properties, two constructors (default and fully qualified and tostring() for each class
        //then test the class you created in TesterProgram by creating objects using both constructors and writing them to the screen. 

        private string _firstName;
        private string _lastName;
        private string _id;
        private float _gpa;


        public string FirstName
        {
            get { return _firstName;}
            set { _firstName = value; }
        }
        
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public float GPA
        {
            get { return _gpa; }
            set { _gpa = value; }
        }

        public Student(string firstName, string lastName, string id, float gpa)
        {
            FirstName = firstName;
            LastName = lastName;
            ID = id;
            GPA = gpa;
        }

        public Student() { }

        public override string ToString()
        {
            return string.Format($"Student first name: {FirstName} student last name: {LastName}");
        }
    }
}
