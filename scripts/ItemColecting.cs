using UnityEngine;
using UnityEngine.UI;
public class ItemColecting : MonoBehaviour
{
    private int strawberries = 0;
    private int apples = 0;
    [SerializeField] private Text txt;
    [SerializeField] private AudioSource col; 
 private void OnTriggerEnter2D(Collider2D collision)
 {  

    if(collision.gameObject.CompareTag("Strawberry"))
    {
        Destroy(collision.gameObject);
        strawberries++;
        // Debug.Log("STRAWBERRIES: " + strawberries);
        col.Play();
        txt.text = "Strawberries: " + strawberries + "/12";
    }
    if(collision.gameObject.CompareTag("apple"))
    {
        Destroy(collision.gameObject);
        apples++;
        txt.text =  "Strawberries: " + strawberries + "/12" +"\n"+"Apples: " + apples +"/1";
        col.Play();
    }
    
 }
}