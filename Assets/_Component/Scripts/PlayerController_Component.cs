using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController_Component : MonoBehaviour
{
    public bool isSendMessage = true;

    public float speed = 20.0f;
    public float speedModifier = 1.0f;

    private InputComponent input;
    private MovementComponent move;

    // Start is called before the first frame update
    void Start()
    {
        move = gameObject.AddComponent<MovementComponent>();
        move.speedModifier = speedModifier;
        input = GetComponent<InputComponent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isSendMessage)
        {
            gameObject.SendMessage("MoveObject", new Vector2(input.HorizontalDirection, input.VerticalDirection));
        }
        else
        {
            move.MoveObject(input.HorizontalDirection, input.VerticalDirection, speed);
        }
    }
}
