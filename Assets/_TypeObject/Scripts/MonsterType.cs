using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MonsterType : MonoBehaviour
{
    public int health;
    private string monsterName;
    private Breed breed;

    public Text nameText;

    public MonsterType (Breed _breed)
    {
        breed = _breed;
        health = _breed.GetHealth();
        monsterName = _breed.GetName();
    }

    private void Start()
    {
        nameText.text = monsterName;
    }

    public string GetAttack()
    {
        return breed.GetAttack();
    }
    
    public string GetName()
    {
        return monsterName;
    }
}
