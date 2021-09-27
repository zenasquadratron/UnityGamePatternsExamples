using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class myObject : MonoBehaviour
{
    [SerializeField] private ObjectData info;

    [SerializeField] private string name;
    [SerializeField] private string threatLevelString;

    private SetObjectInfo setObjectInfo;

    private void Start()
    {
        setObjectInfo = GameObject.Find("myCanvas").GetComponent<SetObjectInfo>();

        name = info.ObjectName;
        threatLevelString = info.ObjectThreat.ToString();
    }

    private void OnMouseUp()
    {
        threatLevelString = "EXTREME";
        Debug.Log("Our Threat is now " + threatLevelString);
    }

    private void OnMouseDown()
    {
        setObjectInfo.OpenObjectInfoPanel();
        setObjectInfo.objectName.text = info.ObjectName;
        setObjectInfo.threatLevel.text = info.ObjectThreat.ToString();
        setObjectInfo.objectIcon.GetComponent<RawImage>().texture = info.ObjectIcon;
    }
}
