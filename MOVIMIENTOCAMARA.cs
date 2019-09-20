using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOVIMIENTOCAMARA : MonoBehaviour
{
    [SerializeField] float speed = 8;
    [SerializeField] string vertical = "Vertical", horizontal = "Horizontal";

    // Arriba se declararon 3 variables serializadas: una velocidad en float y dos strings correspondientes a movimiento vertical y horizontal
    void Start()
    {
        
    }

    // Ahora se procede por medio de las variables previamente nombradas a declarar dos vectores3, que se moveran de acuerdo
    //al producto entre la velocidad previamente declarada, una variable standar de unity y un getAxis

    void Update()
    {
        Vector3 speedvector = speed * transform.forward * Input.GetAxis(vertical);
        transform.position += speedvector * Time.deltaTime;
        Vector3 speedvector2 = speed * transform.right * Input.GetAxis(horizontal);
        transform.position += speedvector2 * Time.deltaTime;
    }
}
