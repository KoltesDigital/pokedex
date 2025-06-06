from training.data import Pokedex

with open("../data/pokedex.json") as file:
    content = file.read()

pokedex = Pokedex.model_validate_json(content)

print(pokedex)
