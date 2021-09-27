using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breed
{
    private int health;
    public int GetHealth()
    {
        return health;
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

    public Breed(string _breedName, int _health, string _attack)
    {
        breedName = _breedName;
        health = _health;
        attack = _attack;
    }

}
