using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetObjectInfo : MonoBehaviour
{
    public GameObject objectInfoPanel;
    public GameObject objectIcon;
    public Text objectName;
    public Text threatLevel;

    public void OpenObjectInfoPanel()
    {
        objectInfoPanel.SetActive(true);
    }

    public void CloseObjectInfoPanel()
    {
        objectInfoPanel.SetActive(false);
    }
}
