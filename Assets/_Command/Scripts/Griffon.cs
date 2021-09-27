using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Griffon : Actor
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            jumpCommand.Execute(name, transform);
        }
        else if (Input.GetKeyDown(KeyCode.T))
        {
            runCommand.Execute(name, transform);
        }
    }
}
