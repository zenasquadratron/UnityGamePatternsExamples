using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invisibility : SuperPower
{
    [SerializeField] private float speed = 0f;
    [SerializeField] private string soundName = "invisibility";
    [SerializeField] private float invisibilityStrength = 1.45f;

    [SerializeField] private AudioClip invisibiltySfx;

    public override void Activate()
    {
        Move(speed);
        PlaySound(invisibiltySfx);
        GoInvisible();

        Debug.Log("SuperPower " + superPowerName + "Activate!!!");
    }

    private void GoInvisible()
    {
        // do the invisibility stuff
    }

    private void PlaySound(AudioClip clip)
    {

    }
}
