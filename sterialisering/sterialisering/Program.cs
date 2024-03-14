using System.IO;
using System.Text.Json;
// SaveGames
//Inställningar
//Highscores

Cake myCake = new();

myCake.Name = JsonSerializer.Deserialize<Cake>(content);

Console.WriteLine(myCake.Name);







//
//string content = "Hej";
//
//string filename = "test.txt";
//
//if(File.Exists(filename))
//{
//    content = File.ReadAllText(filename);
//}
//else