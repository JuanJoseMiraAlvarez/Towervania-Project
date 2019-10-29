using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Wave1
{
    [SerializeField]
    private GameObject enemyPrefab1;
    [SerializeField]
    private int count1;
    [SerializeField]
    private float rate1;

    public GameObject EnemyPrefab1 { get => enemyPrefab1; set => enemyPrefab1 = value; }
    public int Count1 { get => count1; set => count1 = value; }
    public float Rate1 { get => rate1; set => rate1 = value; }
}
