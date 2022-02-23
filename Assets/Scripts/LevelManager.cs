using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    int Levellock;
    public Button[] levelButtons;

    private void Start() {
        Levellock = PlayerPrefs.GetInt("Levellock", 1);

        for (int i = 0; i < levelButtons.Length; i++)
        {
            levelButtons[i].interactable = false;
        }

        for (int i = 0; i < Levellock; i++)
        {
            levelButtons[i].interactable = true;
        }
    }

    public void openLevel(int levelIndex)
    {
        SceneManager.LoadScene(levelIndex);
    }
}
