using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager
{
    private static AudioManager instance;

    private List<AudioClip> clips;
    private string someString;
    private int someInt;

    public static AudioManager Instance
    {
        get
        {
            // Lazy Initializion
            if (instance == null)
            {
                instance = new AudioManager("a string", 0);
            }
            return instance;
        }
    }

    public AudioManager(string s, int i)
    {
        clips = new List<AudioClip>();
        someString = s;
        someInt = i;
    }

    public void SetString(string s)
    {
        someString = s;
    }

    public string GetString()
    {
        return someString;
    }

    public void PlayAudio(int index, Vector3 pos)
    {
        // plays an audio clip

        AudioSource.PlayClipAtPoint(clips[index], pos);
    }

    public void AddClip(AudioClip clip)
    {
        clips.Add(clip);
    }

    public void RemoveClip(AudioClip clip)
    {
        clips.Remove(clip);
    }

    public void PlayRandomClip()
    {
        int randIndex = Random.Range(0, clips.Count);
        AudioSource.PlayClipAtPoint(clips[randIndex], new Vector3(0, 0, 0));
    }
}
