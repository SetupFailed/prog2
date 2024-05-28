using System;

static void Books()
{
    // Skapa tre instanser av Book med olika namn och antal sidor
    Book book1 = new Book("Pissy Jackson", 150);
    Book book2 = new Book("Lord of the kinks", 200);
    Book book3 = new Book("Parry Hotter", 300);


    // Ändra namnet från book1 till book2 eller book3 för att få resultatet för de andra böckerna.
    Console.WriteLine($"Name of book1: {book1.GetName()}");
    Console.WriteLine($"Pages in book1: {book1.GetPages()}");
    Console.WriteLine($"Current page of {book1.GetName()}: {book1.GetCurrentPage()}");

    book1.TurnPage();
    Console.WriteLine($"After turning a page, current page of {book1.GetName()}: {book1.GetCurrentPage()}");

    book1.TurnPage();
    Console.WriteLine($"After turning another page, current page of {book1.GetName()}: {book1.GetCurrentPage()}");
}
Books();
Console.ReadLine();

////////////////////////////////////////////////////////////////

static void Rocks()
{
    List<Rock> rockList = new List<Rock>();

    Console.Write("Ange hur många stenar som ska skapas: ");
    int numberOfRocks;

    // Försök läsa och konvertera antalet stenar från användarens input
    while (!int.TryParse(Console.ReadLine(), out numberOfRocks) || numberOfRocks <= 0)
    {
        Console.Write("Ogiltig inmatning. Vänligen ange ett positivt heltal: ");
    }

    for (int i = 0; i < numberOfRocks; i++)
    {
        Console.Write($"Ange vikten för sten {i + 1}: ");
        double weight;

        // Försök läsa och konvertera vikten från användarens input
        while (!double.TryParse(Console.ReadLine(), out weight) || weight <= 0)
        {
            Console.Write("Ogiltig inmatning. Vänligen ange en positiv vikt: ");
        }

        // Skapa en ny instans av Rock med den angivna vikten och lägg till den i listan
        Rock rock = new Rock(weight);
        rockList.Add(rock);
    }

    // Visa vikterna för alla stenar i listan
    Console.WriteLine("\nVikterna på alla skapade stenar:");
  
    for (int i = 0; i < rockList.Count; i++)
    {
        Console.WriteLine($"Sten {i + 1}: {rockList[i].GetWeight()} kg");
    }
    Console.ReadLine();
}
Rocks();

////////////////////////////////////////////////////////////////////////////////

static void Collars()
    {
        // Skapa instanser av Worker, BlueCollar och WhiteCollar
        Worker worker = new Worker("Alex", 35);
        BlueCollar blueCollar = new BlueCollar("Bob", 40);
        WhiteCollar whiteCollar = new WhiteCollar("Alice", 30);

        // Sätt lön och hämta värden för Worker
        worker.SetWage(50000);
        Console.WriteLine($"Worker: {worker.GetName()}, Age: {worker.GetAge()}, Wage: {worker.GetWage()}");
        Console.ReadLine();

        // Sätt lön och hämta värden för BlueCollar
        blueCollar.SetWage(45000);
        Console.WriteLine($"BlueCollar: {blueCollar.GetName()}, Age: {blueCollar.GetAge()}, Wage: {blueCollar.GetWage()}");
        blueCollar.Build();
        blueCollar.Repair();
        blueCollar.Destroy();
        Console.ReadLine();

        // Sätt lön och hämta värden för WhiteCollar
        whiteCollar.SetWage(60000);
        Console.WriteLine($"WhiteCollar: {whiteCollar.GetName()}, Age: {whiteCollar.GetAge()}, Wage: {whiteCollar.GetWage()}");
        whiteCollar.DrinkCoffee();
        whiteCollar.AttendMeeting();
        whiteCollar.DoSpreadsheets();
        Console.ReadLine();
    }
Collars();

//////////////////////////////////////////////////////////////////////////////////////////////

static void Hardwares()
{
   {
        List<Hardware> hardwareList = new List<Hardware>();

        var hardwareOptions = new List<Tuple<string, Func<Hardware>>>
        {
            new Tuple<string, Func<Hardware>>("Hårddisk", CreateHardDrive),
            new Tuple<string, Func<Hardware>>("Processor", CreateProcessor),
            new Tuple<string, Func<Hardware>>("Grafikkort", CreateGraphicsCard)
        };

        while (true)
        {
            Console.WriteLine("Vilken sorts hårdvara vill du skapa? (1: Hårddisk, 2: Processor, 3: Grafikkort, 0: Avsluta)");
            if (!int.TryParse(Console.ReadLine(), out int choice) || choice < 0 || choice > hardwareOptions.Count)
            {
                Console.WriteLine("Ogiltigt val, försök igen.");
                continue;
            }

            if (choice == 0) break;

            hardwareList.Add(hardwareOptions[choice - 1].Item2());
        }

        // Visa information om all skapad hårdvara
        Console.WriteLine("\nSkapad hårdvara:");
        foreach (var hardware in hardwareList)
        {
            if (hardware is HardDrive hd)
            {
                Console.WriteLine($"Hårddisk - Namn: {hd.GetName()}, Pris: {hd.GetPrice()}, Kapacitet: {hd.GetCapacity()} GB");
            }
            else if (hardware is Processor pr)
            {
                Console.WriteLine($"Processor - Namn: {pr.GetName()}, Pris: {pr.GetPrice()}, Kärnor: {pr.GetCores()}, Klockhastighet: {pr.GetClockSpeed()} GHz");
            }
            else if (hardware is GraphicsCard gc)
            {
                Console.WriteLine($"Grafikkort - Namn: {gc.GetName()}, Pris: {gc.GetPrice()}, Minne: {gc.GetMemory()} GB");
            }
        }
    }

    static Hardware CreateHardDrive()
    {
        Console.Write("Ange namn: ");
        string name = Console.ReadLine();
        Console.Write("Ange pris: ");
        int price = int.Parse(Console.ReadLine());
        Console.Write("Ange kapacitet (GB): ");
        int capacity = int.Parse(Console.ReadLine());
        return new HardDrive(name, price, capacity);
    }

    static Hardware CreateProcessor()
    {
        Console.Write("Ange namn: ");
        string name = Console.ReadLine();
        Console.Write("Ange pris: ");
        int price = int.Parse(Console.ReadLine());
        Console.Write("Ange antal kärnor: ");
        int cores = int.Parse(Console.ReadLine());
        Console.Write("Ange klockhastighet (GHz): ");
        int clockSpeed = int.Parse(Console.ReadLine());
        return new Processor(name, price, cores, clockSpeed);
    }

    static Hardware CreateGraphicsCard()
    {
        Console.Write("Ange namn: ");
        string name = Console.ReadLine();
        Console.Write("Ange pris: ");
        int price = int.Parse(Console.ReadLine());
        Console.Write("Ange minnesstorlek (GB): ");
        int memory = int.Parse(Console.ReadLine());
        return new GraphicsCard(name, price, memory);
    }
}

Hardwares();
