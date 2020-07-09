using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public GameObject recentEnemySpawned;
    public bool canSpawn = true;

    public int spawnCount = 4;
    public float currentTimer = 0f;
    public float defaultTimer = 5f;

    // Start is called before the first frame update
    void Start()
    {
        currentTimer = defaultTimer;
    }

    // Update is called once per frame
    void Update()
    {
        currentTimer -= Time.deltaTime;

        if(canSpawn == true && currentTimer <= 0 && spawnCount > 0)
        {
            recentEnemySpawned = Instantiate(enemyPrefab, transform.position, Quaternion.identity) as GameObject;
            currentTimer = defaultTimer;
            spawnCount--;
        }

        if(recentEnemySpawned != null)
        {
            recentEnemySpawned.transform.Translate(Vector2.right * Time.deltaTime * 5);
        }
        
    }
}
