using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    public int health = 0;

    public Monster(int startingHealth)
    {
        health = startingHealth;
    }

    public virtual string GetAttack()
    {
        return "";
    }

}
