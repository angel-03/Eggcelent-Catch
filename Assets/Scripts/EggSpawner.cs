using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggSpawner : MonoBehaviour
{
    //for spawning at spawnPoints
    public Transform[] spawnPoints;
    public GameObject[] eggPrefabs; //array cuz many types of EggPrefabs
    public GameObject bombPrefab;
    public GameObject heartPrefab;

    float spawnIntervalEgg = 5f;
    float spawnIntervalBomb = 7f;
    float spawnIntervalHeart = 10f;

    private float overTimeEgg = 0.5f;
    private float overTimeBomb = 0.2f;
    private float overTimeHeart = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnEggAtSpawnPoint(spawnIntervalEgg, overTimeEgg));
        StartCoroutine(spawnBombAtSpawnPoint(spawnIntervalBomb, overTimeBomb));  
        StartCoroutine(spawnHeartAtSpawnPoint(spawnIntervalBomb,overTimeHeart)); 
    }

     //spawn Points
    private IEnumerator spawnEggAtSpawnPoint(float spawnIntervalEgg , float overTimeEgg)
    {
        yield return new WaitForSeconds(spawnIntervalEgg);
        int randomEgg = Random.Range(0,eggPrefabs.Length);
        int randomSpawnPoint = Random.Range(0,spawnPoints.Length);
        Instantiate(eggPrefabs[randomEgg], spawnPoints[randomSpawnPoint].position, transform.rotation);
        if(spawnIntervalEgg<1)
        {
            spawnIntervalEgg = 1;
            StartCoroutine(spawnEggAtSpawnPoint(spawnIntervalEgg,overTimeEgg));
        }
        else
        {
            StartCoroutine(spawnEggAtSpawnPoint((spawnIntervalEgg - overTimeEgg),overTimeEgg));
        }
    }

    private IEnumerator spawnBombAtSpawnPoint(float spawnIntervalBomb,float overTimeBomb)
    {
        yield return new WaitForSeconds(spawnIntervalBomb);
        int randomSpawnPoint = Random.Range(0,spawnPoints.Length);
        Instantiate(bombPrefab, spawnPoints[randomSpawnPoint].position, transform.rotation);
        if(spawnIntervalBomb<2.5)
        {
            spawnIntervalBomb = 2.5f;
            StartCoroutine(spawnBombAtSpawnPoint(spawnIntervalBomb,overTimeBomb));
        }
        else
        {
            StartCoroutine(spawnBombAtSpawnPoint((spawnIntervalBomb - overTimeBomb),overTimeBomb));
        }
    }

    private IEnumerator spawnHeartAtSpawnPoint(float spawnIntervalHeart,float overTimeHeart)
    {
        yield return new WaitForSeconds(spawnIntervalHeart);
        int randomSpawnPoint = Random.Range(0,spawnPoints.Length);
        Instantiate(heartPrefab, spawnPoints[randomSpawnPoint].position, transform.rotation);
        if(spawnIntervalHeart<5)
        {
            spawnIntervalHeart = 5f;
            StartCoroutine(spawnHeartAtSpawnPoint(spawnIntervalHeart,overTimeHeart));
        }
        else
        {
            StartCoroutine(spawnHeartAtSpawnPoint((spawnIntervalHeart - overTimeHeart),overTimeHeart));
        }
    }

    
}
