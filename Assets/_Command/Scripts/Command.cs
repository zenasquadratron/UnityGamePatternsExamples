using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Command
{
    public virtual void Execute(string name, Transform transform)
    {
        Debug.Log(name + " executed a command.");
    }

    public virtual void Undo(string name)
    {
        Debug.Log(name + " undid a command.");
    }

    public virtual void List(string name)
    {
        Debug.Log(name + " listed a command.");
    }

    
}
