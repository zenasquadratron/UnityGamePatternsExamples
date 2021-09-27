using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Troll : Monster
{
    public Troll(int value) : base(value)
    {

    }

    public override string GetAttack()
    {
        return "The troll clubs you.";
    }
}
