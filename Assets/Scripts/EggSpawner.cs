using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggSpawner : MonoBehaviour
{
    //for spawning at spawnPoints
    public Transform[] spawnPoints;
    public GameObject[] enemyPrefabs; //array cuz many types of enemyPrefabs
    float spawnInterval = 5f;
    private float overTime = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
         StartCoroutine(spawnEnemyAtSpawnPoint(spawnInterval, overTime));
    }

     //spawn Points
    private IEnumerator spawnEnemyAtSpawnPoint(float spawnInterval , float overTime)
    {
        yield return new WaitForSeconds(spawnInterval);
        int randomEnemy = Random.Range(0,enemyPrefabs.Length);
        int randomSpawnPoint = Random.Range(0,spawnPoints.Length);
        Instantiate(enemyPrefabs[randomEnemy], spawnPoints[randomSpawnPoint].position, transform.rotation);
        if(spawnInterval<1)
        {
            spawnInterval = 1;
            StartCoroutine(spawnEnemyAtSpawnPoint(spawnInterval,overTime));
        }
        else
        {
            StartCoroutine(spawnEnemyAtSpawnPoint((spawnInterval - overTime),overTime));
        }
        Debug.Log(spawnInterval);
    }
}
