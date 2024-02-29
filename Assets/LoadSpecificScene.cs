using UnityEngine.SceneManagement;
using UnityEngine;

public class LoadSpecificScene : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {

  
     if(collision.CompareTag("Player"))
       {
                SceneManager.LoadScene("niveau1");
       }  
    }

}

