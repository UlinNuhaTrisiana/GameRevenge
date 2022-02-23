using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "Exit")
        {
            int currentLevel = SceneManager.GetActiveScene().buildIndex;
            if (currentLevel >= PlayerPrefs.GetInt("Levellock"))
            {
                PlayerPrefs.SetInt("Levellock", currentLevel+1);

                SceneManager.LoadScene(currentLevel + 1);
            }
        }
    }
}
