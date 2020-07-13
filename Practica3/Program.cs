using System;
using System.Collections.Generic;
using System.Text;

namespace Practica03
{
    class Person
    {
        // four fields:
        private string name;
        private int age;
        private int height;
        private int weight;

        // Constructor that takes two argument:
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
            this.weight = 0;
            this.height = 0;
        }

        // methods, getters and setters:
        public void printPerson()
        {
            Console.WriteLine(this.name + " I am " + this.age + " years old");
        }

        public void becomeOlder()
        {
            this.age++;
        }

        public bool adult()
        {
            if (this.age < 18)
            {
                return false;
            }

            return true;
        }


        public int GetAge()
        {
            return this.age;
        }

        public void SetAge(int age)
        {
            this.age = age;
        }

        public String getName()
        {
            return this.name;
        }

        public void settName(string name)
        {
            this.name = name;
        }
    }
}
