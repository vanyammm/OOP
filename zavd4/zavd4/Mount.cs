namespace zavd4;

class Mount : GeographicObject
{
    double Peak;

    public Mount(double x, double y, double peak, string name, string description) : base(x, y, name, description) 
    {
        if (peak < 0)
        {
            throw new ArgumentException($"\"{nameof(peak)}\" cannot be less or equal to zero.");
        }
        Peak = peak;
    }

    public override string GetInfo()
    {
        return base.GetInfo() + $"The peak is: {Peak} meters.\n";
    }
}
