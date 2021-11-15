using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private int poolCount = 4;

    //private GameObject[] enemies;
    private List<GameObject> enemyPool = new List<GameObject>();
    private int nextAvailablePooledEnemy = 0;

    private List<PooledObjectInfo> pooledObjects = new List<PooledObjectInfo>();


    // Start is called before the first frame update
    void Start()
    {
        //GameObject[] temp = new GameObject[poolCount];

        for (int i = 0; i < poolCount; i++)
        {
            GameObject clone = Instantiate(enemyPrefab) as GameObject;
            clone.SetActive(false);
            clone.transform.position = new Vector3(i + 0.5f, 0, 0);
            //enemyPool.Add(clone);

            clone.GetComponent<EnemyController>().poi = new PooledObjectInfo(clone.name + i, false, clone);
            pooledObjects.Add(clone.GetComponent<EnemyController>().poi);
            
        }

        nextAvailablePooledEnemy = enemyPool.Count;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            //ActivateEnemy();
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            //DeactivateEnemy();
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            ActivatePooledObject();
        }
    }

    public void ActivateEnemy()
    {
        if (nextAvailablePooledEnemy > 0)
        {
            enemyPool[nextAvailablePooledEnemy - 1].SetActive(true);
            nextAvailablePooledEnemy -= 1;
        }
        else
        {
            Debug.Log("No more pooled objects available!");
        }

    }

    public void ActivatePooledObject()
    {
        PooledObjectInfo activatedObjected = null;

        foreach (PooledObjectInfo poi in pooledObjects)
        {
            if (!poi.inUse)
            {
                poi.inUse = true;
                poi.go.SetActive(true);
                activatedObjected = poi;
                
                Debug.Log(poi.name + " has been activated");
                break;
            }

            //if (poi.go.active == false)
            //{

            //}
        }

        if (activatedObjected == null)
        {
            Debug.Log("No more pooled objects available!");
        }
    }

    public void DeactivateEnemy()
    {
        if (nextAvailablePooledEnemy < enemyPool.Count)
        {
            enemyPool[nextAvailablePooledEnemy].SetActive(false);
            nextAvailablePooledEnemy += 1;
        }
        else
        {
            Debug.Log("No active enemies to deactivate!");
        }

    }

    public void DeactivatePooledObject(PooledObjectInfo poi)
    {
        PooledObjectInfo deactivatedObject = null;

        foreach (PooledObjectInfo po in pooledObjects)
        {
            if (po == poi)
            {
                po.go.SetActive(false);
                po.inUse = false;
                deactivatedObject = po;

                Debug.Log(po.name + " has been deactivated");
                break;
            }
        }

        if (deactivatedObject == null)
        {
            Debug.Log("No active enemies to deactivate!");
        }
    }

    public void DeactivatePooledObject()
    {

    }
}

[System.Serializable]
public class PooledObjectInfo
{
    public string name;
    public bool inUse;
    public GameObject go;

    public PooledObjectInfo(string _name, bool _inUse, GameObject _gameobject)
    {
        name = _name;
        inUse = _inUse;
        go = _gameobject;
    }
}
