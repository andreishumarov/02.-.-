class Complex
{
    int real, img;
    public Complex()
    {
        real = 0;
        img = 0;
    }
    public void SetValue()
    {
        real = 1;
        img = 1;
    }
    public void DisplayValue()
    {
        Console.WriteLine("Real = " + real);
        Console.WriteLine("Imaginary = " + img);
    }
    ~Complex()
    {
        Console.WriteLine("Destructor was called");
    }
    }
class Program
{
    static void Main(string[]args)
    {
        Complex C = new Complex();
        C.SetValue();
        C.DisplayValue();
    }
}