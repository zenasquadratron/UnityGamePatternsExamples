using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputComponent : MonoBehaviour
{
    private float horizontalDirection;
    public float HorizontalDirection { get { return horizontalDirection; } }
    private float verticalDirection;
    public float VerticalDirection { get { return verticalDirection; } }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalDirection = Input.GetAxis("Horizontal");
        verticalDirection = Input.GetAxis("Vertical");
    }
}
