using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class WaveSpawner : MonoBehaviour
{
    [SerializeField]
    private Wave[] waves;
    private static int EnemiesAlive = 0;
    //public Transform enemyPrefab;
    public Transform spawnPoint;
    private float countdown = 5f;
    private int waveNumber = 1;
    [SerializeField]
    private float timeBetweenWaves = 5f;
    //[SerializeField]
    private int waveIndex = 0;
    [SerializeField]
    public GameObject enemigo;

    public int WaveNumber { get => waveNumber; set => waveNumber = value; }

    void Update()
    {
        if (EnemiesAlive>0)
        {
            return;
        }
        if (countdown<=0f)
        {
            StartCoroutine(SpawnWave());
            countdown = timeBetweenWaves;
            return;
        }
        countdown -= Time.deltaTime;
    }
    IEnumerator SpawnWave()
    {
        Wave wave = waves[waveIndex];

        EnemiesAlive = wave.Count;

        for (int i = 0; i < wave.Count; i++)
        {
            SpawnEnemy(/*wave.EnemyPrefab*/);
            yield return new WaitForSeconds(1f / wave.Rate);
        }

        waveIndex++;
        /*for (int i = 0; i < waveNumber; i++)
        {
            SpawnEnemy();
        }
        waveNumber++;*/
    }

    void SpawnEnemy(/*GameObject EnemyPrefab*/)
    {
        Instantiate(enemigo, spawnPoint.position,spawnPoint.rotation);
        EnemiesAlive++;
    }
}
