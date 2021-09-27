using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "objectdata", menuName = "Object Data", order = 51)]
public class ObjectData : ScriptableObject
{
    public enum Threat { NONE, LOW, MODERATE, HIGH }

    [SerializeField] private string objectName;
    [SerializeField] private Threat objectThreat;
    [SerializeField] private Texture objectIcon;

    public string ObjectName { get {return objectName; } }
    public Threat ObjectThreat { get { return objectThreat; } }
    public Texture ObjectIcon { get { return objectIcon;} }
}
