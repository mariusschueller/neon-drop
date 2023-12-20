using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{

    public int index;
    public string levelName;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            //SceneManager.LoadScene(index);

            SceneManager.LoadScene(levelName);
            
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

}
