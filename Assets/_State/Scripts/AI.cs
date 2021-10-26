using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour
{
    private State currentState;
    private Animator animator;
    public int hp = 5;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        currentState = new Idle(animator);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            currentState = new Idle(animator);
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            currentState = new Attack(animator);
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            currentState = new Walk(animator);
        }

        switch(currentState.state)
        {
            case (State.STATE.ATTACK):
                // Do Attack Stuff
                AttackStuff();
                break;
            case (State.STATE.IDLE):
                // Do Idle Stuff
                IdleStuff();
                break;
            case (State.STATE.WALK):
                // Do Walk Stuff
                WalkStuff();
                break;
            default:
                break;
        }

        currentState = currentState.Process();
    }

    public void IdleStuff()
    {
        Debug.Log("Whacha gonna do about it?");
    }

    public void AttackStuff()
    {
        Debug.Log("Attacking!");
    }

    public void WalkStuff()
    {
        Debug.Log("Just Walking.");
    }
}
