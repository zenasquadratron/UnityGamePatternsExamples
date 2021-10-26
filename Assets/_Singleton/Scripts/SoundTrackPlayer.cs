using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundTrackPlayer : MonoBehaviour
{
    AudioManager audioManager;
    AudioSource audioSource;

    private static SoundTrackPlayer _instance;

    public List<AudioClip> clips;

    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }

    }

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioManager = AudioManager.Instance;

        foreach (AudioClip ac in clips)
        {
            Debug.Log(ac.name);
            AudioManager.Instance.AddClip(ac);

            //audioManager.AddClip(ac);

        }

        audioSource.clip = AudioManager.Instance.GetAudioClip(0);
        audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}


