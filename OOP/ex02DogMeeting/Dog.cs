using System;
using System.Collections.Generic;
using System.Text;

namespace ex02DogMeeting
{
    class Dog
    {
        private string name;
        public Dog()
        {
            this.name = "Balkan";
        }
        public Dog(string name)
        {
            this.name = name;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public void Bark()
        {
            Console.WriteLine("{0} said: Wow-wow!", name);
        }
    }
}
