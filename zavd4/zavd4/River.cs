namespace zavd4;

class River : GeographicObject 
{
    double Length, Speed;

    public River(double x, double y, double speed, double length, string name, string description) : base (x, y, name, description)
    {
        Length = length;
        Speed = speed;
    }

    public override string GetInfo()
    {
        return base.GetInfo() + $"Speed is: {Speed} m/s\nLength is: {Length} km.\n";
    }

}
