namespace zavd4;

internal interface IGeographicalObject
{
    string Name { get; }

    string Description { get; }

    double X { get; }

    double Y { get; }

    string GetInfo();
}
