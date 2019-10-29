using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    private int vida;
    private float velocidad_de_mov;
    [SerializeField]private int dano_final;
    private int dano_a_soldados;
    private bool magia;
    //private int plata;

    

    public Enemigo() { }

    public int Vida { get => vida; set => vida = value; }
    public float Velocidad_de_mov { get => velocidad_de_mov; set => velocidad_de_mov = value; }
    public int Dano_final { get => dano_final; set => dano_final = value; }
    public int Dano_a_soldados { get => dano_a_soldados; set => dano_a_soldados = value; }
    public bool Magia { get => magia; set => magia = value; }
    //public int Plata { get => plata; set => plata = value; }
    public void Atacar(){ }
    public void Usar_magia() { }

    void Morteficar(Collider enemi)
    {
        Enemigo stats = enemi.GetComponent<Enemigo>();
        stats.Vida -= dano_final;

        Destroy(gameObject);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Puerta"))
        {
            Morteficar(other);
        }
        if (other.CompareTag("Bala"))
        {
            Afectar(other);

        }
        if (other.CompareTag("Paralizador"))
        {
            StartCoroutine(Detener(other));

        }
    }
    void Afectar(Collider bala)
    {
        balabasica stats = bala.GetComponent<balabasica>();
        Vida -= stats.dano;
       
    }
    IEnumerator Detener(Collider enemi)
    {
        paralisador stats = enemi.GetComponent<paralisador>();
        Vida -= stats.dano;
        Velocidad_de_mov /= 2;

        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<Collider>().enabled = false;

        yield return new WaitForSeconds(stats.duracion);

        Velocidad_de_mov *= 2;

    }


    /* public void OnCollisionEnter(Collision collision)
     {

         if (collision.gameObject.CompareTag("Puerta"))
         {
             Destroy(gameObject);
         }
     }*/


}
