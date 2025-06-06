from enum import StrEnum
from typing import List

from pydantic import BaseModel, Field


class Type(StrEnum):
    Bug = "Bug"
    Dark = "Dark"
    Dragon = "Dragon"
    Electric = "Electric"
    Fairy = "Fairy"
    Ice = "Ice"
    Fighting = "Fighting"
    Fire = "Fire"
    Flying = "Flying"
    Ghost = "Ghost"
    Grass = "Grass"
    Ground = "Ground"
    Normal = "Normal"
    Poison = "Poison"
    Psychic = "Psychic"
    Rock = "Rock"
    Steel = "Steel"
    Water = "Water"


class Evolution(BaseModel):
    number: str = Field(alias="num")
    name: str


class Pokemon(BaseModel):
    id: int
    number: str = Field(alias="num")
    name: str
    types: List[str]
    height: float
    weight: float
    weaknesses: List[str]
    previous_evolutions: List[Evolution] = Field(
        default_factory=list, alias="prev_evolutions"
    )
    next_evolutions: List[Evolution] = Field(default_factory=list)


class Pokedex(BaseModel):
    pokemons: List[Pokemon]
