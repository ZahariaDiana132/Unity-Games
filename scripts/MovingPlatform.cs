using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    [SerializeField] private GameObject[] waypoints;
    private int index;
    [SerializeField] private float speed = 2f;
     private void Update()
    {
        if(Vector2.Distance(waypoints[index].transform.position,transform.position) < .1f)
        {
            index++;
            if(index >= waypoints.Length)
            {
                index=0;
            }
        }
        transform.position = Vector2.MoveTowards(transform.position,waypoints[index].transform.position,Time.deltaTime*speed);
    }
}
