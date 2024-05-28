using System;

public class Book
{
    private string Name { get; set; }
    private int Pages { get; set; }
    private int CurrentPage;

    public Book(string n, int p)
    {
        Name = n;
        Pages = p;
        CurrentPage = 0;
    }

    public void TurnPage()
    {
        if (CurrentPage < Pages)
        {
            CurrentPage++;
        }
        else
        {
            Console.WriteLine($"{Name} has no more pages to turn.");
        }
    }

    public int GetCurrentPage()
    {
        return CurrentPage;
    }

    public string GetName()
    {
        return Name;
    }

    public int GetPages()
    {
        return Pages;
    }   

}

////////////////////////////////////////////////////////////////////////////////////////
public class Rock
{
    private double weight;

    // Konstruktor som tar emot vikten och sparar den i den privata variabeln weight
    public Rock(double w)
    {
        weight = w; 
    }

    // Metod som returnerar värdet på weight
    public double GetWeight()
    {
        return weight;
    }
}

////////////////////////////////////////////////////////////////////////////////////////

public class Worker
{
    protected string name;
    protected int age;
    protected double wage;

    // Konstruktor som tar emot namn och ålder
    public Worker(string name, int age)
    {
        this.name = name;
        this.age = age;
        this.wage = 0;
    }

    // Metod för att sätta lön
    public void SetWage(double wage)
    {
        this.wage = wage;
    }

    // Metoder för att hämta namn, ålder och lön
    public string GetName()
    {
        return name;
    }

    public int GetAge()
    {
        return age;
    }

    public double GetWage()
    {
        return wage;
    }
}

public class BlueCollar : Worker
{
    // Konstruktor som tar emot namn och ålder och skickar dem till basklassens konstruktor
    public BlueCollar(string name, int age) : base(name, age)
    {
    }

    // Metoder som utför olika uppgifter (innehåll valfritt)
    public void Build()
    {
        Console.WriteLine($"{name} is building something.");
    }

    public void Repair()
    {
        Console.WriteLine($"{name} is repairing something.");
    }

    public void Destroy()
    {
        Console.WriteLine($"{name} is destroying something.");
    }
}

public class WhiteCollar : Worker
{
    // Konstruktor som tar emot namn och ålder och skickar dem till basklassens konstruktor
    public WhiteCollar(string name, int age) : base(name, age)
    {
    }

    // Metoder som utför olika uppgifter (innehåll valfritt)
    public void DrinkCoffee()
    {
        Console.WriteLine($"{name} is drinking coffee.");
    }

    public void AttendMeeting()
    {
        Console.WriteLine($"{name} is attending a meeting.");
    }

    public void DoSpreadsheets()
    {
        Console.WriteLine($"{name} is doing spreadsheets.");
    }
}

public class Hardware
{
    private string name;
    private double price;

    // Konstruktor som tar emot namn och pris
    public Hardware(string name, double price)
    {
        this.name = name;
        this.price = price;
    }

    // Metoder för att hämta namn och pris
    public string GetName()
    {
        return name;
    }

    public double GetPrice()
    {
        return price;
    }
}
public class HardDrive : Hardware
{
    private int capacity;

    // Konstruktor som tar emot namn, pris och kapacitet
    public HardDrive(string name, double price, int capacity) : base(name, price)
    {
        this.capacity = capacity;
    }

    // Metod för att hämta kapacitet
    public int GetCapacity()
    {
        return capacity;
    }
}

public class Processor : Hardware
{
    private int cores;
    private double clockSpeed;

    // Konstruktor som tar emot namn, pris, antal kärnor och klockhastighet
    public Processor(string name, double price, int cores, double clockSpeed) : base(name, price)
    {
        this.cores = cores;
        this.clockSpeed = clockSpeed;
    }

    // Metoder för att hämta antal kärnor och klockhastighet
    public int GetCores()
    {
        return cores;
    }

    public double GetClockSpeed()
    {
        return clockSpeed;
    }
}

public class GraphicsCard : Hardware
{
    private int memory;

    // Konstruktor som tar emot namn, pris och minnesstorlek
    public GraphicsCard(string name, double price, int memory) : base(name, price)
    {
        this.memory = memory;
    }

    // Metod för att hämta minnesstorlek
    public int GetMemory()
    {
        return memory;
    }
}