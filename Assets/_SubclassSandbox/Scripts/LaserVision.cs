using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserVision : SuperPower
{
    [SerializeField] private int LaserPower = 9001;

    public override void Activate()
    {
        PlaySound(audioClips[0]);
        SpawnParticles();
        FireLazerEyes();

        Debug.Log("SuperPower " + superPowerName + "Activate!!!");
    }

    private void FireLazerEyes()
    {
        // Do LazerEyes
        
    }

}
