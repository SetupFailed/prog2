using RestSharp;
using System.Text.Json;

RestClient client = new("https://pokeapi.co/api/v2/");

string PokemonName = "snorlax";
RestRequest request = new($"pokemon/{PokemonName}");

RestResponse response = client.GetAsync(request).Result;

Console.WriteLine(response.Content);
Console.ReadLine();