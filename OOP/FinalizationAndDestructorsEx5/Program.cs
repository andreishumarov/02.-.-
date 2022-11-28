public class Student
{
    public string name;
    public int  age;
    public string  gender;
    public string  department;
    public Student(string name, int age, string gender, string department)
    {
        this.name = name;
        this.age = age;
        this.gender = gender;
        this.department = department;
    }
    public string getName()
    {
        return this.name;
    }
    public int getAge()
    {
        return this.age;
    }
    public string getGender()
    {
        return this.gender;
    }
    public  string getDepartment()
    {
        return this.department;
    }
    ~Student()
    {
        Console.WriteLine("Destructor of Student Class has been invoked");
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        Student objStudentA = new Student("Harry", 22, "Male", "Computer Science");
        Student objStudentB = new Student("Diana", 21, "Female", "Bisiness Studies");
        Console.WriteLine(objStudentA.getName());
        Console.WriteLine(objStudentA.getAge());
        Console.WriteLine(objStudentA.getGender());
        Console.WriteLine(objStudentA.getDepartment());

        Console.WriteLine(objStudentB.getName());
        Console.WriteLine(objStudentB.getAge());
        Console.WriteLine(objStudentB.getGender());
        Console.WriteLine(objStudentB.getDepartment());
    }
}
