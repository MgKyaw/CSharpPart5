using System;

string[] pettingZoo =
{
    "alpacas",
    "capybaras",
    "chickens",
    "ducks",
    "emus",
    "geese",
    "goats",
    "iguanas",
    "kangaroos",
    "lemurs",
    "llamas",
    "macaws",
    "ostriches",
    "pigs",
    "ponies",
    "rabbits",
    "sheep",
    "tortoises",
};

// RandomizeAnimals();

// string[,] group = AssignGroup();

Console.WriteLine("School A");

// PrintGroup(group);

void RandomizeAnimals()
{
    int i = 0;
    int r = 1;

    string temp = pettingZoo[i];
    pettingZoo[i] = pettingZoo[r];
    pettingZoo[r] = temp;
}
