using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private int poolCount = 4;

    private List<GameObject> enemyPool = new List<GameObject>();
    private int nextAvailablePooledEnemy = 0;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < poolCount; i++)
        {
            GameObject clone = Instantiate(enemyPrefab) as GameObject;
            clone.SetActive(false);
            clone.transform.position = new Vector3(i + 0.5f, 0, 0);
            enemyPool.Add(clone);
            
        }

        nextAvailablePooledEnemy = enemyPool.Count;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            ActivateEnemy();
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            DeactivateEnemy();
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
}
