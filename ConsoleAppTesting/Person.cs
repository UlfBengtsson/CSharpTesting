using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTesting
{
    public class Person
    {
        int age = -1;
        public int Age
        {
            get
            {
                return age;
            }
            private set
            {
                if (value > 130)
                {
                    throw new ArgumentOutOfRangeException("Age", "Is the person older than 129 years?!?!?");
                }
                age = value;
            }
        }
        public string Name { get; set; }

        public Person(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }
    }
}
