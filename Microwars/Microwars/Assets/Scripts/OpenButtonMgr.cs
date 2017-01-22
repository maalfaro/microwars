﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenButtonMgr : MonoBehaviour {

    public GameObject backgroundMicroWave;
    public bool isVisible = true;
    public PowerButtonMgr powerButtonMgr;
    public SangresitaScript sangresitaScript;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ShowBackground()
    {
        if (!isVisible)
        {
            if (GameObject.FindGameObjectWithTag("JuanD") != null)
            {
                if (GameObject.FindGameObjectWithTag("JuanD").GetComponent<JuanDCharacterMgr>().state == 11)
                {
                    if (powerButtonMgr.counter == 0)
                    {
                        JuanDCharacterMgr.DEAD = true;
                        sangresitaScript.enabled = true;
                        sangresitaScript.Blood();
                        GameObject.FindGameObjectWithTag("JuanD").GetComponent<JuanDCharacterMgr>().PlayMuerte();
                        GameObject.FindGameObjectWithTag("JuanD").GetComponent<JuanDCharacterMgr>().Muerte();
                    }
                    else
                    {
                        //TODO FAILED
                    }
                }
            }
        }
        backgroundMicroWave.SetActive(isVisible = !isVisible);
    }
}
