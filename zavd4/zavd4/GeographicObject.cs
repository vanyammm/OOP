namespace zavd4;

abstract class GeographicObject : IGeographicObject
{
    double X, Y;
    string Name, Description;

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
