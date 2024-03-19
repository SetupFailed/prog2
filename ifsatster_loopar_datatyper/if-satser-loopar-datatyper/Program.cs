

using System.Linq.Expressions;
using System.Net.Security;

if (6 > 3)
{
    Console.WriteLine("Hello, World!");
}

Console.WriteLine("please enter username");
Console.WriteLine("and password");


bool loggedIn = true;

while ((loggedIn == true))
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
        return;
    }
}





