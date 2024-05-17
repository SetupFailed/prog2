/*

string[] toys = { "Bakugan", "Beyblade", "Omnitrix", "Tamagotchi", "HotWheels" };
string[] people = { "Sunnie", "Tommi", "Tin", "Zacke", "Nicole" };

foreach (string i in toys)
{
    Console.WriteLine(i);
}



int[] num = { 1, 3, 5, 7, 9 };

for (int i = 0; i < toys.Length; i++)
{
    Console.WriteLine(people[i] + " ger " + toys[i] + " betyget " + num[i]);
}

*/


string input = "";

List<string> CitiesList = new();

while (input.ToLower() != "exit") // (lowercase sensitiv4e)
{   
    Console.WriteLine("Type a city or type 'exit' to exit");
    input = Console.ReadLine();

    if (input.ToLower() != "exit") // Check if user wants to exit (lowercase sensitive)
    {
        CitiesList.Add(input); // Add the city to the list
    }
    Console.WriteLine("Cities entered:");
    foreach (string city in CitiesList)
    {
        Console.WriteLine(city); // Output the cities entered
    }
}