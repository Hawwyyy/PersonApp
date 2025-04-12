using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApp
{
    internal class Student : Person
    {
        private string StudentID;

        public Student(string name, int age, string address, string studentID) : base(name, age, address)
        {
            StudentID = studentID;
        }

        public string GetStudentInformation()
        {
            return $"Name: {Name} \nAge: {Age} \nAddress: {Address} \nStudent ID: {StudentID}";
        }
    }
}
