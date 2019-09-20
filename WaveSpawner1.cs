﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner1 : MonoBehaviour
{
    public Transform enemyPrefab;

    public Transform spawnPoint;

    public float timeBetweenWaves = 10f;
    private float countdown = 10f;
    private int waveNumber = 1;

    void Update()
    {
        if (countdown<=0f)
        {
            SpawnWave();
            countdown = timeBetweenWaves;
        }
        countdown -= Time.deltaTime;
    }
    void SpawnWave()
    {

        for (int i = 0; i < waveNumber; i++)
        {
            SpawnEnemy();
        }
        waveNumber++;
    }

    void SpawnEnemy()
    {
        Instantiate(enemyPrefab, spawnPoint.position,spawnPoint.rotation);
    }
}