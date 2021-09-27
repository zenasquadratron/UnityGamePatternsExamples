using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundTrackPlayer : MonoBehaviour
{
    AudioManager audioManager;

    public List<AudioClip> clips;

    private void Awake()
    {
        if (GameObject.Find("Soundtrack") == null)
        {
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
       
        audioManager = AudioManager.Instance;

        foreach (AudioClip ac in clips)
        {
            AudioManager.Instance.AddClip(ac);

            audioManager.AddClip(ac);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            AudioManager.Instance.PlayRandomClip();
        }
    }
}


