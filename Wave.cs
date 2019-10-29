using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Wave
{
    [SerializeField]
    private GameObject enemyPrefab;
    [SerializeField]
    private int count;
    [SerializeField]
    private float rate;

    public GameObject EnemyPrefab { get => enemyPrefab; set => enemyPrefab = value; }
    public int Count { get => count; set => count = value; }
    public float Rate { get => rate; set => rate = value; }
}
