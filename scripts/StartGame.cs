using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StartGame : MonoBehaviour
{   [SerializeField] private AudioSource but;
   public void StartTheGame(){
     Invoke("Act",1f);
    but.Play();
   }
   public void EndGame(){
     Invoke("Act2",1f);
     but.Play();
   }

   private void Act()
   {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
   }
    private void Act2()
   {
    SceneManager.LoadScene(0);
   }
}
