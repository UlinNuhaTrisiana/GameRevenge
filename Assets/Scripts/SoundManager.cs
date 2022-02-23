﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    [SerializeField] Image backsoundOn;
    [SerializeField] Image backsoundOff;
    private bool muted = false;

    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("muted"))
        {
            PlayerPrefs.SetInt("muted", 0);
            Load();
        }
        else
        {
            Load();
        }

        UpdateButtonIcon();
        AudioListener.pause = muted;
    }

    public void OnButtonPress()
    {
        if (muted == false)
        {
            muted = true;
            AudioListener.pause = true;
        }
        else
        {
            muted = false;
            AudioListener.pause = false;
        }

        Save();
        UpdateButtonIcon();
    }

    private void UpdateButtonIcon(){
        if (muted == false)
        {
            backsoundOn.enabled = true;
            backsoundOff.enabled = false;
        }
        else
        {
            backsoundOn.enabled = false;
            backsoundOff.enabled = true;
        }
    }

    private void Load(){
        muted = PlayerPrefs.GetInt("muted") == 1; //if muted=1 then muted set to true
    }

    private void Save(){
        PlayerPrefs.SetInt("muted", muted ? 1 : 0); // if muted is true then use 1, and if muted is false then use 0
    }
}
