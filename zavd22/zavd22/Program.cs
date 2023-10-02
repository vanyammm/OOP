namespace zavd22;

class Program
{
    static void Main(string[] args)
    {
        Team RabbitSoft = new Team("RabbitSoft");

        RabbitSoft.TeamAddMember(new Manager("Anton"));

        RabbitSoft.TeamAddMember(new Developer("Danil"));

        RabbitSoft.TeamShowFullInfo();

        Console.ReadKey();
    }
}