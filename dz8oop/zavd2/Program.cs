// В цьому завданні також було порушено принцип єдиності 
// відповідальності.
// EmailSender відправляв електронні листи та вів логування у консоль

// Тож я створив клас Logger для логування


using System;

class Email
{
    public String Theme { get; set; }
    public String From { get; set; }
    public String To { get; set; }
}

class Logger
{
    public Action<string> LogAction { get; set; }

    public Logger()
    {
        LogAction = (message) => Console.WriteLine("Log: " + message);
    }

    public void Log(string message)
    {
        LogAction(message);
    }
}

class EmailSender
{
    private Logger logger;

    public EmailSender(Logger logger)
    {
        this.logger = logger;
    }

    public void Send(Email email)
    {
        // ... sending...
        logger.Log("Email from '" + email.From + "' to '" + email.To + "' was sent");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Email e1 = new Email()
        {
            From = "Me",
            To = "Vasya",
            Theme = "Who are you?"
        };
        Email e2 = new Email()
        {
            From = "Vasya",
            To = "Me",
            Theme = "vacuum cleaners!"
        };
        Email e3 = new Email()
        {
            From = "Kolya",
            To =
        "Vasya",
            Theme = "No! Thanks!"
        };
        Email e4 = new Email()
        {
            From = "Vasya",
            To = "Me",
            Theme = "washing machines!"
        };
        Email e5 = new Email()
        {
            From = "Me",
            To = "Vasya",
            Theme = "Yes"
        };
        Email e6 = new Email()
        {
            From = "Vasya",
            To =
        "Petya",
            Theme = "+2"
        };

        Logger logger = new Logger();

        EmailSender es = new EmailSender(logger);
        es.Send(e1);
        es.Send(e2);
        es.Send(e3);
        es.Send(e4);
        es.Send(e5);
        es.Send(e6);
        Console.ReadKey();
    }
}