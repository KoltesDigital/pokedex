use serde::Deserialize;

#[derive(Debug, Deserialize)]
pub enum Type {
	Bug,
	Dark,
	Dragon,
	Electric,
	Fairy,
	Ice,
	Fighting,
	Fire,
	Flying,
	Ghost,
	Grass,
	Ground,
	Normal,
	Poison,
	Psychic,
	Rock,
	Steel,
	Water,
}

#[derive(Debug, Deserialize)]
pub struct Evolution {
	#[serde(rename = "num")]
	pub number: String,
	pub name: String,
}

#[derive(Debug, Deserialize)]
pub struct Pokemon {
	pub id: u32,
	#[serde(rename = "num")]
	pub number: String,
	pub name: String,
	pub types: Vec<Type>,
	pub height: f32,
	pub weight: f32,
	pub weaknesses: Vec<Type>,
	#[serde(default)]
	pub next_evolutions: Vec<Evolution>,
	#[serde(default, rename = "prev_evolutions")]
	pub previous_evolutions: Vec<Evolution>,
}

#[derive(Debug, Deserialize)]
pub struct Pokedex {
	pub pokemons: Vec<Pokemon>,
}
