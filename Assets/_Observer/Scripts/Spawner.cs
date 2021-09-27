using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject objectPrefab;
    public int maxObjects = 10;
    private int currentObjectCount = 0;
    public int CurrentObjectCount
    {
        get { return currentObjectCount; }
    }

    public Vector3 playAreaSize;

    public float dropHeight = 5.0f;
    public float spawnDelay = 2.0f;
    public float spawnInterval = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreateObject", spawnDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CreateObject()
    {
        if (currentObjectCount < maxObjects)
        {
            int x = (int)Random.Range(-playAreaSize.x, playAreaSize.x);
            int z = (int)Random.Range(-playAreaSize.z, playAreaSize.z);
            Vector3 pos = new Vector3(x, dropHeight, z);
            GameObject go = Instantiate(objectPrefab, pos, Quaternion.identity);
            currentObjectCount++;
        }
    }

    public void AdjustCounter(int value)
    {
        currentObjectCount += value;
    }

}
