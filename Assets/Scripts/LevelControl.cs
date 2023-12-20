using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelControl : MonoBehaviour {

    public int index;
    public string levelName;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
           

            SceneManager.LoadScene(levelName);
        }
    }

}
