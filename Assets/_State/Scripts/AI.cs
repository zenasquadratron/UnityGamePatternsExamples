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

        switch(currentState.name)
        {
            case (State.STATE.ATTACK):
                // Do Attack Stuff
                OtherStuff();
                break;
            case (State.STATE.IDLE):
                // Do Idle Stuff
                PickUpRoutine();
                break;
            case (State.STATE.WALK):
                // Do Walk Stuff
                OtherStuff();
                PickUpRoutine();
                break;
            default:
                break;
        }

        //currentState = currentState.Process(animator);
    }

    public void PickUpRoutine()
    {

    }

    public void OtherStuff()
    {

    }
}
