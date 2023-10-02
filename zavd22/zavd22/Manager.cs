namespace zavd22;

class Manager : Worker
{
    private Random rand;

    public Manager(string name) : base(name)
    {
        Position = "Manager";
        rand = new Random();
        FillWorkDay();
    }
    public override void FillWorkDay()
    {
        int n = rand.Next(1, 10);
        for (int i = 0; i < n; i++) 
        {
            Call();
        }
        Relax();
        n = rand.Next(1, 5);
        for (int i = 0; i < n; i++)
        {
            Call();
        }
    }

}
