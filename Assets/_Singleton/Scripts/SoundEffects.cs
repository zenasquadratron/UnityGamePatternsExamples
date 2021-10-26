using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffects : MonoBehaviour
{
    [SerializeField] private SoundEffectInfo[] soundEffects;

    private static SoundEffects _instance;

    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {


        foreach (SoundEffectInfo sei in soundEffects)
        {
            AudioManager.Instance.AddClipByName(sei.name, sei.audioClip);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            AudioManager.Instance.PlayAudioByName("Robot", transform.position);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            AudioManager.Instance.PlayAudioByName("Laser", transform.position);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            AudioManager.Instance.PlayRandomSoundEffect();
        }

    }
}

[System.Serializable]
public class SoundEffectInfo
{
    public string name;
    public AudioClip audioClip;
}
