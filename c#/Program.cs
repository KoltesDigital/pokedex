using System.Text.Json;

class Program
{
	static void Main()
	{
		var pokedex = JsonSerializer.Deserialize<Pokedex>(File.ReadAllText("../data/pokedex.json"))!;

		Console.WriteLine(pokedex);
	}
}
