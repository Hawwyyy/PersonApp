using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApp
{
    internal class Person
    {
        private string name;
        private int age;
        private string address;

        public Person(string name, int age, string address)
        {
            this.name = name;
            this.age = age;
            this.address = address;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string GetInformation()
        {
            return "Name: " + name + " \nAge: " + age + " \nAddress: " + address;
        }
    }
}

