using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Actor
{
    public List<Command> commands = new List<Command>();
    //public Dictionary<KeyCode, Command> commandz = new Dictionary<KeyCode, Command>();

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.J))
        {
            jumpCommand.Execute(name);
            commands.Add(jumpCommand);
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            runCommand.Execute(name);
            commands.Add(runCommand);
        }
        else if (Input.GetKeyDown(KeyCode.L))
        {
            Debug.Log("Listing past commands: ");
            foreach(Command c in commands)
            {
                c.List(name);

            }

            
        }
        else if (Input.GetKeyDown(KeyCode.U))
        {
            Debug.Log("Undoing the following command:");
            int i = commands.Count - 1;
            commands[i].Undo(name);
            commands.RemoveAt(i);

        }

        //foreach(KeyCode kc in commandz.Keys)
        //{
        //    if (Input.GetKeyDown(kc))
        //    {
        //        if (Input.GetKey(KeyCode.LeftShift))
        //        {
        //            commandz[kc].Undo(name);
        //        }
        //        else
        //        {
        //            commandz[kc].Execute(name);
        //        }
        //    }

        //}
    }
}
