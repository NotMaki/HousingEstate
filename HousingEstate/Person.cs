using System;
using System.Collections.Generic;
using System.Text;

namespace HousingEstate
{
    internal class Person
    {
        private string name;
        private int age;
        private string surname;

        public Person(string name, string surname, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }

        public override string ToString()
        {
            return String.Format($"Name: {name}\nSurname: {surname}\nAge: {age}\n");
        }
    }
}
