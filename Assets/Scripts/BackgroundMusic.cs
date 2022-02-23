using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    private static BackgroundMusic backSound;

    void Awake() {
        if (backSound == null)
        {
            backSound = this;
            DontDestroyOnLoad(backSound);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
