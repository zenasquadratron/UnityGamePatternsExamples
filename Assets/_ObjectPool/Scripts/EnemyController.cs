using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private float lifespan = 0.5f;

    private SpawnManager spawnManager;
    private float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        spawnManager = GameObject.Find("Spawner").GetComponent<SpawnManager>();
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= lifespan)
        {
            spawnManager.DeactivateEnemy();
            timer = 0;
        }
    }


}
