﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class start : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space)) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
        }
	}
    public void PlayGame() {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }

}