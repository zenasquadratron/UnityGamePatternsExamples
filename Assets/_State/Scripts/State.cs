using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State 
{
    public enum STATE
    {
        IDLE, WALK, ATTACK
    };

    public enum EVENT
    {
        ENTER, UPDATE, EXIT
    };

    public STATE state;
    public EVENT stage;
    protected State nextState;

    public State()
    {
        stage = EVENT.ENTER;
    }

    public virtual void Enter()
    {
        stage = EVENT.UPDATE;
    }

    public virtual void Update()
    {
        stage = EVENT.UPDATE;
    }

    public virtual void Exit()
    {
        stage = EVENT.EXIT;
    }

    public State Process()
    {
        if (stage == EVENT.ENTER) Enter();
        if (stage == EVENT.UPDATE) Update();
        if (stage == EVENT.EXIT)
        {
            Exit();
            return nextState;
        }
        return this;
    }
}

public class Idle : State
{
    Animator anim;

    public Idle(Animator animator)
    {
        state = STATE.IDLE;
        anim = animator;
        // Set Data
    }

    public override void Enter()
    {
        // do the Enter
        anim.StopPlayback();

        base.Enter();
    }

    public override void Update()
    {
        // do the Update
        // condition to exit
        anim.Play("something");
        if (Input.GetKeyDown(KeyCode.Space))
        {
            nextState = new State();
            stage = EVENT.EXIT;
        }
    }

    public override void Exit()
    {
        // do the Exit
        anim.StopPlayback();
        base.Exit();
    }
}

public class Walk : State
{
    Animator anim;

    public Walk(Animator animator)
    {
        state = STATE.WALK;
        anim = animator;
        // Set Data
    }

    public override void Enter()
    {
        // do the Enter
        anim.Play("Walk");
        base.Enter();
    }

    public override void Update()
    {
        // do the Update
        if (true)
        {
            nextState = new State();
            stage = EVENT.EXIT;
        }
    }

    public override void Exit()
    {
        // do the Exit
        base.Exit();
    }
}

public class Attack : State
{
    Animator anim;

    public Attack(Animator animator)
    {
        state = STATE.ATTACK;
        anim = animator;
        // Set Data
    }

    public override void Enter()
    {
        // do the Enter
        anim.Play("Attack");
        base.Enter();
    }

    public override void Update()
    {
        // do the Update
        if (true)
        {
            nextState = new State();
            stage = EVENT.EXIT;
        }
    }

    public override void Exit()
    {
        // do the Exit
        base.Exit();
    }
}
