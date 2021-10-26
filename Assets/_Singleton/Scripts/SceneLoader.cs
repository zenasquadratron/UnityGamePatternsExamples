using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    private int currentScene = 1;

    private static SceneLoader _instance;

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
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            currentScene++;

            if (currentScene > 2)
            {
                currentScene = 1;
            }

            SceneManager.LoadScene("Singleton " + currentScene);

            //AudioManager.Instance.PlayAudio(0, transform.position);
        }
    }
}
