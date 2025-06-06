using System.Text.Json.Serialization;

public static class Types
{
	public const string Bug = "Bug";
	public const string Dark = "Dark";
	public const string Dragon = "Dragon";
	public const string Electric = "Electric";
	public const string Fairy = "Fairy";
	public const string Ice = "Ice";
	public const string Fighting = "Fighting";
	public const string Fire = "Fire";
	public const string Flying = "Flying";
	public const string Ghost = "Ghost";
	public const string Grass = "Grass";
	public const string Ground = "Ground";
	public const string Normal = "Normal";
	public const string Poison = "Poison";
	public const string Psychic = "Psychic";
	public const string Rock = "Rock";
	public const string Steel = "Steel";
	public const string Water = "Water";
}

public class Evolution
{
	[JsonPropertyName("num")]
	public string Number { get; set; }

	[JsonPropertyName("name")]
	public string Name { get; set; }

	public override string ToString() { return $"Evolution: Number = {Number}, Name = {Name}"; }
}

public class Pokemon
{
	[JsonPropertyName("id")]
	public int Id { get; set; }

	[JsonPropertyName("num")]
	public string Number { get; set; }

	[JsonPropertyName("name")]
	public string Name { get; set; }

	[JsonPropertyName("types")]
	public string[] Types { get; set; }

	[JsonPropertyName("height")]
	public float Height { get; set; }

	[JsonPropertyName("weight")]
	public float Weight { get; set; }

	[JsonPropertyName("weaknesses")]
	public string[] Weaknesses { get; set; }

	[JsonPropertyName("prev_evolutions")]
	public Evolution[] PreviousEvolutions { get; set; } = [];

	[JsonPropertyName("next_evolutions")]
	public Evolution[] NextEvolutions { get; set; } = [];

	public override string ToString() => $"Pokemon: Id = {Id}, Number = {Number}, Name = {Name}";
}

public class Pokedex
{
	[JsonPropertyName("pokemons")]
	public Pokemon[] Pokemons { get; set; }

	public override string ToString() => $"Pokedex: [\n{string.Join("\n", Pokemons.Select(pokemon => "  " + pokemon.ToString()))}\n]";
}
