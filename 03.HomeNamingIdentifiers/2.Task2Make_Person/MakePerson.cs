using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Task2Make_Person
{
    class MakePerson
    {
        internal enum Gender
        {
            Male,
            Female
        }

        internal class Person
        {
            public Gender Gender
            {
                get;
                set;
            }

            public string Name
            {
                get;
                set;
            }

            public int Age
            {
                get;
                set;
            }
        }

        internal class Generator
        {
            public Person MakePerson(int age)
            {
                Person newPerson = new Person();
                newPerson.Age = age;
                if (age % 2 == 0)
                {
                    newPerson.Name = "Thug";
                    newPerson.Gender = Gender.Male;
                }
                else
                {
                    newPerson.Name = "Hoe";
                    newPerson.Gender = Gender.Female;
                }

                return newPerson;
            }
        }

        static void Main(string[] args)
        {
            var Pesho = new Person();
            Console.WriteLine(Pesho);
        }
    }
}
