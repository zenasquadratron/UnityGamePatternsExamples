using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : MonoBehaviour
{
    public GameObject target;
    public Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = target.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = target.transform.position + offset;
    }
}
