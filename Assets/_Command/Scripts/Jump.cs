using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : Command
{
    private float jumpHeight = 0;

    public Jump(float height)
    {
        jumpHeight = height;
    }



    public override void Execute(string name)
    {
        Debug.Log(name + " has jumped " + jumpHeight + " feet into the air!");
    }



    //public override void List(string name)
    //{
    //    Debug.Log(name + " jumped " + jumpHeight + " feet into the air!");
    //}



    public override void Undo(string name)
    {
        base.Undo(name);
        Debug.Log(name + " has returned to the ground from " + jumpHeight + " feet up!");
    }
}
