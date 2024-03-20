

using System.Linq.Expressions;
using System.Net.Security;
/*
if (6 > 3)
{
    Console.WriteLine("Hello, World!");
}

Console.WriteLine("please enter username");
Console.WriteLine("and password");


bool loggedIn = false;

while (loggedIn == false)
{
    string userName = Console.ReadLine();
    string password = Console.ReadLine();

    if ((userName == "noname") && (password == "nopass"))
    {
        loggedIn = true;
        Console.WriteLine("Welcome!");

        for (int i = 0; i < 32; i++)
            Console.WriteLine("Hello World!");
        break;
    }

    else
    {
        loggedIn = false;
        Console.WriteLine("wrong username and password mother fucker *BOOM*");
    }
}





Console.WriteLine("guess the number, you have '5' tries");
for (var i = 0; i < 5; i++)
{
    string five = Console.ReadLine();
    int numberFive = int.Parse(five);

    if (numberFive > 5)
    {
        Console.WriteLine("HÖGRE ÄN 5!!");
        break;
    }
    else if (numberFive != 5) 
    {
        Console.WriteLine("Womp Womp");
    }
}
*/

bool valid = false;

while (valid == true)
{
    Console.WriteLine("skriv in ett tal");
    string validInput = Console.ReadLine();

    if (int.TryParse(validInput, out int someNumber))
    {
        
    }
}

/*int numberFive = 0;

bool success = int.TryParse(five, out numberFive);*/