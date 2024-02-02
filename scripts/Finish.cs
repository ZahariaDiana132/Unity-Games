using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Finish : MonoBehaviour
{
    private AudioSource finishSound;
    private bool ok = true;
    [SerializeField] private Text txt;
    // Start is called before the first frame update
    void Start()
    {
        finishSound = GetComponent<AudioSource>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player") && ok == true)
        {
           txt.text = "GG WP!";
           finishSound.Play();
           ok = false;
           Invoke("CompleteLevel",1.5f);
        }
    }

    private void CompleteLevel()
    {
         
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }


}
