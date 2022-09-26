using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace ex01
{
    class Person
    {
        private string name;
        private int age;
        public Person() {
        }
        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public void IntroduceYourself()
        {
            Console.WriteLine("Здравейте! Аз съм {0} и съм на {1} години.", name, age);
        }
    }
}