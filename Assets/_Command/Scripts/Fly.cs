using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly : Command
{
    public float flyHeight = 10.0f;

    public Fly(float height)
    {

    }

    public override void Execute(string name, Transform transform)
    {
        //throw new NotImplementedException();
    }

    public override void List(string name)
    {
        //throw new NotImplementedException();
    }

    public override void Undo(string name)
    {
        //throw new NotImplementedException();
    }
}
