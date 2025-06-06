import fs from "fs";
import { Pokedex } from "./data";

const content = fs.readFileSync("../data/pokedex.json", "utf-8");
const pokedex = JSON.parse(content) as Pokedex;

console.log(pokedex);
