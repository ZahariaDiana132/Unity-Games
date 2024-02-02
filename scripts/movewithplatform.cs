using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movewithplatform : MonoBehaviour
{
//    void OnCollisionEnter2D(Collision2D other)
//    {
  
//    }
//    void OnCollisionExit2D(Collision2D other)
//    {

//    }

   void OnTriggerEnter2D(Collider2D other)
   {
      if(other.CompareTag("Player"))
    {
        other.gameObject.transform.SetParent(transform);
    }
   }

   void OnTriggerExit2D(Collider2D other)
   {
         if(other.CompareTag("Player"))
    {
        other.gameObject.transform.SetParent(null);
    }
   }
}
