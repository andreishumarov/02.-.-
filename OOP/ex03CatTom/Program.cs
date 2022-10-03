using System;

namespace ex03CatTom
{
    class Program
    {
        static void Main()
        {
            /* string firstCatName = null;
             Console.WriteLine("Write first cat name: ");
             firstCatName = Console.ReadLine();
             string firstCatAge = null;
             Console.WriteLine("Write first cat age: ");
             firstCatAge = Console.ReadLine();
             firstCatlenght = null;
             Console.WriteLine("Write first cat lenght: ");
             firstCatlenght = Console.ReadLine();
             */
            Cat myCat01 = new Cat();
            Cat myCat02 = new Cat("Tom");
            Cat myCat03 = new Cat("Tom", 2);
            Cat myCat04 = new Cat("Tom", 2, 52);
            Cat myCat05 = new Cat("Tom", 2, 52, true);
            myCat01.makeSound();
            myCat02.makeSound();
            myCat03.makeSound();
            myCat04.makeSound();
            myCat05.makeSound();
        }
    }
}
