namespace zavd4;

class Program
{
    static void Main(string[] args)
    {
        //GeographicObject obj = new GeographicObject(255.0, 230.5, "Object", "Lorem ipsum");
        River psel = new River(123.0, 220.0, 10.2, 240, "Psel", "Lorem ipsum river");
        Mount everest = new Mount(1350.0, -300.0, 7459.0, "Everest", "Lorem ipsum mountain");
        Console.WriteLine(psel.GetInfo());
        Console.WriteLine(everest.GetInfo());
    }
}