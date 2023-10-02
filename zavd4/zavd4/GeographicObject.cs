namespace zavd4;

abstract class GeographicObject : IGeographicalObject
{
    public string Name { get; }

    public string Description { get; }

    public double X { get; }

    public double Y { get; }

    public GeographicObject(double x, double y, string name, string description)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException($"\"{nameof(name)}\" can not be null or white space.", nameof(name));
        }

        if (string.IsNullOrWhiteSpace(description))
        {
            throw new ArgumentException($"\"{nameof(description)}\" can not be null or white space.", nameof(description));
        }

        X = x; 

        Y = y; 

        Name = name;

        Description = description;
    }
    
    public virtual string GetInfo()
    {
        return $"Name: {Name}\nCoordinates (x ; y): ({X} ; {Y});\nDescription: {Description}\n";
    }
}
