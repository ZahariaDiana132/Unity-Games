using System.Collections;
using System.Collections.Generic;
using UnityEditor.Callbacks;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Death : MonoBehaviour
{
    private Animator anim;
    private Rigidbody2D rg;
    [SerializeField] private Text txt;
    
    [SerializeField] private AudioSource death;

    // Start is called before the first frame update
    private void Start()
    {
        rg = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("trap"))
        {
            Die();
            
            
        }
    }

    private void Die()
    {
        rg.bodyType = RigidbodyType2D.Static;
        anim.SetTrigger("death");
        death.Play();
         txt.text = "Oh no!";
    }

    private void RestartLvl()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
