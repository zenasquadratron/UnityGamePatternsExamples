using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementComponent : MonoBehaviour
{
    public bool isUsingInputComponent = true;
    public float speedModifier = 1.0f;
    private float speed = 20.0f;

    private InputComponent input;

    // Start is called before the first frame update
    void Start()
    {
        speed *= speedModifier;
        input = GetComponent<InputComponent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isUsingInputComponent)
        {
            transform.Translate(Vector3.right * input.HorizontalDirection * speed * Time.deltaTime);
            transform.Translate(Vector3.up * input.VerticalDirection * speed * Time.deltaTime);
        }
    }

    public void MoveObject(Vector2 value)
    {
        transform.Translate(Vector3.right * value.x * speed * Time.deltaTime);
        transform.Translate(Vector3.up * value.y * speed * Time.deltaTime);
    }

    public void MoveObject(float x, float y, float s)
    {
        transform.Translate(Vector3.right * x * s * Time.deltaTime);
        transform.Translate(Vector3.up * y * s * Time.deltaTime);
    }
}
