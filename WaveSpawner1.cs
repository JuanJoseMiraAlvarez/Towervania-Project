using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class WaveSpawner1 : MonoBehaviour
{
    //[SerializeField]
    public Wave1[] waves1;
    private static int EnemiesAlive = 0;
    //public Transform enemyPrefab1;
    public Transform spawnPoint1;
    private float countdown = 5f;
    private int waveNumber = 1;
    [SerializeField]
    private float timeBetweenWaves = 5f;
    //[SerializeField]
    private int wave1Index = 0;
    [SerializeField]
    public GameObject enemigo;
    void Update()
    {
        if (EnemiesAlive > 0)
        {
            return;
        }
        if (countdown <= 0f)
        {
            StartCoroutine(SpawnWave());
            countdown = timeBetweenWaves;
            return;
        }
        countdown -= Time.deltaTime;
    }
    IEnumerator SpawnWave()
    {

        Wave1 wave1 = waves1[wave1Index];

        EnemiesAlive = wave1.Count1;

        for (int i = 0; i < wave1.Count1; i++)
        {
            SpawnEnemy(/*wave1.EnemyPrefab1*/);
            yield return new WaitForSeconds(1f / wave1.Rate1);
        }

        wave1Index++;
    }

    void SpawnEnemy(/*GameObject EnemyPrefab1*/)
    {
        Instantiate(enemigo, spawnPoint1.position,spawnPoint1.rotation);
        EnemiesAlive++;
    }
}
