using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This is the base class
public abstract class SuperPower : MonoBehaviour
{
    public string superPowerName;
    public ParticleSystem particleSystem;
    public AudioSource audioSource;
    public List<AudioClip> audioClips = new List<AudioClip>();

    private int someInt = 0;

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.S))
        {
            Activate();
        }
    }

    // This is the sandbox method that a subclass has to have in it's own version of
    public abstract void Activate();

    // All the operations a derived class needs to perform - called from Activate()
    protected void Move(float speed)
    {
        // moves the player
    }

    protected void PlaySound(AudioClip clip)
    {
        // plays a sound effect
        audioSource.PlayOneShot(clip);

        int i = someInt;

        someInt = 1;
    }

    protected void SpawnParticles()
    {
        // plays a particle effect
        particleSystem.Play();

        someInt = 0;
    }
    
}
