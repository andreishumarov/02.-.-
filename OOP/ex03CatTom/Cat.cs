using System;
using System.Collections.Generic;
using System.Text;

namespace ex03CatTom
{
    class Cat
    {
        string name;
        int age;
        int length;
        bool isMale;
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
        public int Length
        {
            get { return length; }
            set { length = value; }
        }
        public bool IsMale
        {
            get { return isMale; }
            set { isMale = value; }
        }
        public Cat()
        {
            this.name= "Tom";
            this.age = 2;
            this.length = 52;
            this.isMale = true;
        }
        public Cat(string name)
        {
            this.name = name;
            this.age = 2;
            this.length = 52;
            this.isMale = true;
        }
        public Cat(string name, int age)
        {
            this.name = name;
            this.age = age;
            this.length = 52;
            this.isMale = true;
        }
        public Cat(string name, int age, int length)
        {
            this.name = name;
            this.age = age;
            this.length = length;
            this.isMale = true;
        }
        public Cat(string name, int age, int length, bool isMale)
        {
            this.name = name;
            this.age = age;
            this.length = length;
            this.isMale = isMale;
        }
        public void makeSound() => Console.WriteLine("Cat {0}, age {1} with length {2} said: Meow!", name, age, length);
    }
} 