export enum Type {
	Bug = "Bug",
	Dark = "Dark",
	Dragon = "Dragon",
	Electric = "Electric",
	Fairy = "Fairy",
	Ice = "Ice",
	Fighting = "Fighting",
	Fire = "Fire",
	Flying = "Flying",
	Ghost = "Ghost",
	Grass = "Grass",
	Ground = "Ground",
	Normal = "Normal",
	Poison = "Poison",
	Psychic = "Psychic",
	Rock = "Rock",
	Steel = "Steel",
	Water = "Water",
}

export interface Evolution {
	num: string;
	name: string;
}

export interface Pokemon {
	id: number;
	num: string;
	name: string;
	types: Type[];
	height: number;
	weight: number;
	weaknesses: Type[];
	prev_evolutions: Evolution[];
	next_evolutions: Evolution[];
}

export interface Pokedex {
	pokemons: Pokemon[];
}
