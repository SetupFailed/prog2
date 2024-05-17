

using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
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
string validInput = "";


/*
while (valid == false)
{
    Console.WriteLine("skriv in ett tal");
    validInput = Console.ReadLine();

    if (int.TryParse(validInput, out int someNumber))
    {
        Console.WriteLine($"Du skrev {someNumber}");
        valid = true;
    }
    else
    {
        Console.WriteLine("ETT NUMMER DIN KUK!");
        valid = false;
    }

}
Console.WriteLine("inte i loop");
Console.ReadLine();
*/
int randomNumber = Random.Shared.Next(1, 11);
int guess = 0;

while (!valid)
{

    Console.WriteLine("Gissa siffran mellan 1 - 10");
    validInput = Console.ReadLine();

    if (!int.TryParse(validInput, out guess))
    {
        Console.WriteLine("ETT NUMMER DIN KUK!");
        valid = false;
    }
     if (guess < randomNumber)
    {
        Console.WriteLine("Högre");
        
    }
    else if (guess > randomNumber)
    {
        Console.WriteLine("lägre");
        
    }
    else if (guess == randomNumber)
    {
        Console.WriteLine("YIPPIEEEE!! RÄTT NUMMER");
        Console.ReadLine();
        break;
    }

}
Console.ReadLine();