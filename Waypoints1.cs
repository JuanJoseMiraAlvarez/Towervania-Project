
using System.Collections.Generic;
using UnityEngine;

public class Waypoints1 : MonoBehaviour
{
    public static Transform[] waypoints1;
    public static Transform[] waypoints2;

    void Awake()
    {
        waypoints1 = new Transform[transform.childCount];
        for (int i = 0; i < waypoints1.Length; i++)
        {
            waypoints1 [i]=transform.GetChild(i);
        }
         

     //void Awake()
    {
        waypoints2 = new Transform[transform.childCount];
        for (int i = 0; i < waypoints2.Length; i++)
        {
            waypoints2 [i]=transform.GetChild(i);
        }
    }
    }

}
