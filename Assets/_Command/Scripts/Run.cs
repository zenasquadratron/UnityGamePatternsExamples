using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Run : Command
{
    private float runDistance = 0;

    public Run(float distance)
    {
        runDistance = distance;
    }

    public override void Execute(string name)
    {
        // do the jump stuff

        Debug.Log(name + " has run forward " + runDistance + " miles!");
    }

    //public override void List(string name)
    //{
    //    Debug.Log(name + " ran " + runDistance + " miles");
    //}

    public override void Undo(string name)
    {
        // undo the jump stuff
        base.Undo(name);
        Debug.Log(name + " has run back " + runDistance + " miles!");
    }
}
