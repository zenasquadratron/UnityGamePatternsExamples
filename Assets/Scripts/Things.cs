using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Things : MonoBehaviour
{
    // Spell Buttons
    public Button button1;
    public Text text1_1;
    public Text text1_2;

    public Button button2;
    public Text text2_1;
    public Text test2_2;

    public Button button3;
    public Text text3_1;
    public Text text3_2;

    // Spell Buttons version 2
    public ButtonInfo[] buttonInfos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        text1_1.text = "test string";

        buttonInfos[0].text1.text = "another test string";

        foreach (ButtonInfo bi in buttonInfos)
        {
            if (bi.name == "spell 1")
            {
                bi.button.interactable = true;
            }
            else
            {
                bi.button.interactable = false;
            }
            
        }
    }
}

[System.Serializable]
public class ButtonInfo
{
    public int id;
    public string name;
    public Button button;
    public Text text1;
    public Text text2;
}