class Person
{
    string name;
    void getName()
    {
        Console.WriteLine("Name: " + name);
    }
    ~Person()
    {
        Console.WriteLine("Destructor called");
    }
    public static void Main(string[] args)
    {
        Person p1 = new Person();
        p1.name = "Ed Sheeran";
        p1.getName();
    }
}