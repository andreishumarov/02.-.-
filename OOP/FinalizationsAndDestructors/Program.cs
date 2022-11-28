using System.Reflection.Metadata;
 class User
{
    public User()
    {
        Console.WriteLine("An Instance of class created");
    }
     ~User()
    {
        Console.WriteLine("An Instance of class destroy");
    }
}
class Program
{
    static void Main(string[]args)
    {
        Details();
        GC.Collect();
        Console.ReadLine();
    }
    public static void Details()
    {
        User user = new User();
    }
}