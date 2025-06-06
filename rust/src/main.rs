mod data;

use std::fs;

use data::*;

fn main() {
	let content = fs::read_to_string("../data/pokedex.json").expect("failed to read data file");

	let pokedex: Pokedex = serde_json::from_str(&content).expect("failed to parse JSON");

	println!("{:#?}", pokedex);
}
