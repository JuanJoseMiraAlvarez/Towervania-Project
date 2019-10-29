
using System.Collections.Generic;
using UnityEngine;

public class MovimientoEnemigo2 : MonoBehaviour
{
    [SerializeField]
    private float speed = 10f;
    private Transform target;
    private int wavepointIndex = 0;


    void Start()
    {
        target = Waypoints2.waypoints2[0]; 
    }

    void Update()
    {
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);


        if (Vector3.Distance(transform.position,target.position)<=0.2f)
        {
            GetNextWaypoint();
        }

    }

    void GetNextWaypoint()
    {

       /* if (wavepointIndex >= Waypoints2.waypoints2.Length-1)
        {
            Destroy(gameObject);
            return;
        }*/
        wavepointIndex++;
        target = Waypoints2.waypoints2[wavepointIndex];
    }
}
