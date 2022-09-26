using System;

namespace ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            Person firstPerson = new Person();
            firstPerson.Name = "Vasil";
            firstPerson.Age = 17;
            firstPerson.IntroduceYourself();
            firstPerson.Age = 18;
            firstPerson.IntroduceYourself();
            firstPerson.Name = "Marto";
            firstPerson.Age = 19;
            firstPerson.IntroduceYourself();
        }
    }
}