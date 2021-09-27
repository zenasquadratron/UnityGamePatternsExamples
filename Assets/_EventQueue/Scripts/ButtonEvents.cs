using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonEvents : MonoBehaviour
{
    public Color enterColor;
    public Color exitColor;

    public Image image;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EnterButtonColor()
    {
        image.color = enterColor;
    }

    public void ExitButtonColor()
    {
        image.color = exitColor;
    }
}
