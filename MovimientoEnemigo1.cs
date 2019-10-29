
using System.Collections.Generic;
using UnityEngine;

public class MovimientoEnemigo1 : MonoBehaviour
{
    [SerializeField]
    private  float speed = 10f;
    private Transform target;
    private int wavepointIndex = 0;
    private Enemigo enemigo;


    void Start()
    {
        enemigo = GetComponent<Enemigo>();
        target = Waypoints1.waypoints1[0]; 
    }

    void Update()
    {
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);


        if (Vector3.Distance(transform.position,target.position)<=0.1f)
        {
            GetNextWaypoint();
            
        }

    }

    void GetNextWaypoint()
    {

        /*if (wavepointIndex >= Waypoints1.waypoints1.Length-1)
        {
            //Destroy(gameObject);
            return;
        }*/
        wavepointIndex++;
        target = Waypoints1.waypoints1[wavepointIndex];
        return;
    }
}
