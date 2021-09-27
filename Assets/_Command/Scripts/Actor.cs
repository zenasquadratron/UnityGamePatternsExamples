using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actor : MonoBehaviour
{
    public string name;
    public float jumpHeight = 2.0f;
    public float runDistance = 10.0f;

    public Run runCommand;
    public Jump jumpCommand;

    // Start is called before the first frame update
    void Start()
    {
        jumpCommand = new Jump(jumpHeight);
        runCommand = new Run(runDistance);
    }

    void Update()
    {
        
    }
}
