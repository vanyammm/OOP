using System.Diagnostics.Contracts;

namespace zavd22;

class Team
{
    private readonly List<Worker> teams = new List<Worker>();
    public readonly string Name;

    public Team(string name)
    {
        Name = name;
    }

    public void TeamAddMember(Worker worker)
    {
        teams.Add(worker);
    }

    public void TeamShowInfo()
    {
        Console.WriteLine($"Team name: {Name}\n");
        foreach (Worker worker in teams)
        {
            Console.WriteLine(worker.Name);
        }
    }

    public void TeamShowFullInfo()
    {
        Console.WriteLine($"Team name: {Name}");
        foreach (Worker worker in teams)
        {
            Console.WriteLine($"Name: {worker.Name}, Position: {worker.Position}, Work day: {worker.WorkDay}");
        }
    }

}
