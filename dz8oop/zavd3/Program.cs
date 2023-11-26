// В цьому завданні було порушено принцип заміщення Лісков

// Клас Square успадковував клас Rectangle + до цього
// він перевизначав Width та Height таким чином, що
// вони встановлювали висоту і ширину одночасно, що призводило до
// невірного результату.

// Тож я зробив абстрактний клас Shape, від якого тепер
// наслідуються класи Rectangle та Square
// зі сторонами Width, Height та абстрактним методом
// знаходження площі фігури

// В класі Rectangle було тільки перевизначено метод GetArea()
// а в Square ще створенна змінна Side замість двох Height та Width

using System;

abstract class Shape
{
    public int Width { get; set; }
    public int Height { get; set; }

    public abstract int GetArea();
}

class Rectangle : Shape
{
    public override int GetArea()
    {
        return Width * Height;
    }
}

class Square : Shape
{
    public int Side
    {
        get { return Width; }
        set { Width = value; Height = value; }
    }

    public override int GetArea()
    {
        return Side * Side;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Rectangle rect = new Rectangle();
        rect.Width = 5;
        rect.Height = 10;
        Console.WriteLine(rect.GetArea());

        Square square = new Square();
        square.Side = 5;
        Console.WriteLine(square.GetArea());

        Console.ReadKey();
    }
}
