using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonController : MonoBehaviour
{
    public enum DragonState { SLEEPING, WALKING, FLYING }
    public DragonState dragonState;

    public Animator animation;

    // Start is called before the first frame update
    void Start()
    {
        dragonState = DragonState.SLEEPING;
        animation.SetBool("isSleeping", true);
        animation.SetBool("isFlying", false);
    }

    // Update is called once per frame
    void Update()
    {
        switch(dragonState)
        {
            case (DragonState.SLEEPING):
                Debug.Log("The Dragon is sleeping.");
                
                break;
            case (DragonState.WALKING):
                Debug.Log("The dragon is walking.");
                break;
            case (DragonState.FLYING):
                Debug.Log("The Dragon is flying.");
                break;
            default:
                Debug.Log(dragonState + " is not a valid state.");
                break;
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            dragonState = DragonState.SLEEPING;
            animation.SetBool("isSleeping", true);
            animation.SetBool("isFlying", false);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            dragonState = DragonState.WALKING;
            animation.SetBool("isSleeping", false);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            dragonState = DragonState.FLYING;
            animation.SetBool("isFlying", true);
        }
    }
}
