using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class AppearOnCollision : MonoBehaviour
{
    [SerializeField]private GameObject objectToAppear;
    [SerializeField] private AudioSource bub; 
    private int ok = 0;
    private void Start()
    {
       objectToAppear.SetActive(false);
       
    }
    private void OnTriggerEnter2D(Collider2D other)
    { 
        if (other.CompareTag("Player") && ok == 0)
        {
            objectToAppear.SetActive(true);
            bub.Play();
            ok = 1;
        }
    }
}

