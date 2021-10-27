using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager
{
    private static AudioManager instance;

    private List<AudioClip> soundTrackClips;

    private Dictionary<string, AudioClip> soundEffectClips;

    public static AudioManager Instance
    {
        get
        {
            // Lazy Initializion
            if (instance == null)
            {
                instance = new AudioManager();
            }
            return instance;
        }
    }

    public AudioManager()
    {
        soundTrackClips = new List<AudioClip>();
        soundEffectClips = new Dictionary<string, AudioClip>();
    }


    public void PlayAudio(int index, Vector3 pos)
    {
        // plays an audio clip

        AudioSource.PlayClipAtPoint(soundTrackClips[index], pos);
    }

    public AudioClip GetAudioClip(int index)
    {
        return soundTrackClips[index];
    }

    public void PlayAudioByName(string value, Vector3 pos)
    {
        AudioSource.PlayClipAtPoint(soundEffectClips[value], pos);
    }

    public void AddClip(AudioClip clip)
    {
        soundTrackClips.Add(clip);
    }

    public void AddClipByName(string s, AudioClip ac)
    {
        soundEffectClips.Add(s, ac);
    }

    public void RemoveClip(AudioClip clip)
    {
        soundTrackClips.Remove(clip);
    }

    public void RemoveClipByName(string s)
    {
        soundEffectClips.Remove(s);
    }
}
