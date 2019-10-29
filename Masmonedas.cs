using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Masmonedas : MonoBehaviour
{
    [SerializeField]public int puntaje;
    // Start is called before the first frame update
    void Awake()
    {
        puntaje = 20;
    }
    void OnDestroy()
    {
        gamescore2.score += puntaje;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
