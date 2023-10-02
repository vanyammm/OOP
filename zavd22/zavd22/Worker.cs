namespace zavd22;

abstract class Worker
{
    public string Name;
    public string Position;
    public string WorkDay = "";

    public Worker(string name)
    {
        Name = name;
    }

    protected void Call()
    {
        WorkDay += "call, ";
    }

    protected void WriteCode()
    {
        WorkDay += "write code, ";
    }

    protected void Relax()
    {
        WorkDay += "relax, ";
    }

    public abstract void FillWorkDay();

}
