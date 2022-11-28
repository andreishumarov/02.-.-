using System.Globalization;

class Program
{
    static int counter = 0;
    string name = "Demo Program";
    static void Main(string[] args)
    {
        counter++;
        Display("Hello World!");
        //name не е зададен като стринг
        name = "New Demo Program";
        //Не може да я зададе като главна папка
        SetRootFolder("D:\MyProgram");
    }
    static void Display(string text)
    {
        Console.WriteLine(text);
    }
    public  void SetRootFolder(string path) { }
        }