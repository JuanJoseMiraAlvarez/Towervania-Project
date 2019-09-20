using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    private int vida;
    private float velocidad_de_mov;
    private int dano_final;
    private int dano_a_soldados;
    private bool magia;

    

    public Enemigo() { }

    public int Vida { get => vida; set => vida = value; }
    public float Velocidad_de_mov { get => velocidad_de_mov; set => velocidad_de_mov = value; }
    public int Dano_final { get => dano_final; set => dano_final = value; }
    public int Dano_a_soldados { get => dano_a_soldados; set => dano_a_soldados = value; }
    public bool Magia { get => magia; set => magia = value; }

    public void Atacar(){ }
    public void Usar_magia() { }

    
}
