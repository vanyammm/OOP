namespace zavd22;

class Developer : Worker
{
    public Developer(string name) : base(name)
    {
        Position = "Developer";
        FillWorkDay();
    }

    public override void FillWorkDay()
    {
        WriteCode();
        Call(); 
        Relax();
        WriteCode();
    }

}
