using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torre : MonoBehaviour
{
    private int precio;
    private int precio_de_mejora;
    private int precio_al_destruir;
    private int dano_proyectil;
    private Collider rango_de_accion;
    private float tiempo_de_disparo;
    private float tiempo_de_mejora;
    private bool efecto_del_disparo;

    public int Precio { get => precio; set => precio = value; }
    public int Precio_de_mejora { get => precio_de_mejora; set => precio_de_mejora = value; }
    public int Precio_al_destruir { get => precio_al_destruir; set => precio_al_destruir = value; }
    public int Dano_proyectil { get => dano_proyectil; set => dano_proyectil = value; }
    public Collider Rango_de_accion { get => rango_de_accion; set => rango_de_accion = value; }
    public float Tiempo_de_disparo { get => tiempo_de_disparo; set => tiempo_de_disparo = value; }
    public float Tiempo_de_mejora { get => tiempo_de_mejora; set => tiempo_de_mejora = value; }
    public bool Efecto_del_disparo { get => efecto_del_disparo; set => efecto_del_disparo = value; }

     public Torre() { }

    public void Detectar()
    {

    }

    public void Disparar()
    { }

    public void Generar()
    {

    }
    public void Mejorar()
    { }
    public void Destruir()
    {

    }
}
