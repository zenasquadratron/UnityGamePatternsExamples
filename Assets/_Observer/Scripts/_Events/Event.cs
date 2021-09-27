using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Event", menuName = "Game Event", order = 52)]
public class Event : ScriptableObject
{
    private List<EventListener> eventListeners = new List<EventListener>();

    public void Register(EventListener listener)
    {
        eventListeners.Add(listener);
    }

    public void Unregister(EventListener listener)
    {
        eventListeners.Remove(listener);
    }

    public void Occurred()
    {
        for (int i = 0; i < eventListeners.Count; i++)
        {
            eventListeners[i].OnEventOccurs();
        }
    }
}
