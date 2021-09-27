using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragon : Monster
{
    public Dragon(int value) : base(value)
    {
        
    }

    public override string GetAttack()
    {
        return "The dragon breaths fire!";
    }
}
