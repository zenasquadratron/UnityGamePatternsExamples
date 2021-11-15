using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breed
{
    private int health;
    public int GetHealth()
    {
        //return health;
        return breedData.Health;
    }

    private string attack;
    public string GetAttack()
    {
        return attack;
    }

    private string breedName;
    public string GetName()
    {
        return breedName;
    }

    private BreedData breedData;
    public BreedData BreedDataz;

    public Breed(string _breedName, int _health, string _attack)
    {
        breedName = _breedName;
        health = _health;
        attack = _attack;
    }

    public Breed(BreedData _breedData)
    {
        breedName = _breedData.BreedName;
        health = _breedData.Health;
        attack = _breedData.Attack;

        breedData = _breedData;
    }

}
