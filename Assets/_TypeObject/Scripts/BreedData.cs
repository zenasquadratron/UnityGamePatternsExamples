using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "monsterdata", menuName = "Monster Data", order = 51)]
public class BreedData : ScriptableObject
{
    [SerializeField] private string breedName;
    [SerializeField] private int health;
    [SerializeField] private string attack;

    public string BreedName { get { return breedName; } }
    public int Health { get { return health; } }
    public string Attack { get { return breedName + " " + attack; } }
}
