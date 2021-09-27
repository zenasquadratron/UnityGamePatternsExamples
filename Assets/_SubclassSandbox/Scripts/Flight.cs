using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flight : SuperPower
{
    public float flightHeight = 10.0f;

    public override void Activate()
    {
        Fly();
        PlaySound(audioClips[0]);
        SpawnParticles();

        Debug.Log("SuperPower " + superPowerName + "Activate!!!");
    }

    private void Fly()
    {
        transform.position = new Vector3(transform.position.x, flightHeight, transform.position.z);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        base.Update();

        if (Input.GetKeyDown(KeyCode.F))
        {
            Activate();
        }
    }
}
