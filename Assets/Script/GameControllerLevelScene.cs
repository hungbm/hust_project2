﻿using UnityEngine;
using System.Collections;

public class GameControllerLevelScene : MonoBehaviour {
    public static int chosenLevel;
    public static bool clickedLevel = false;
    public int level;
	// Use this for initialization
	void Start () {
        clickedLevel = false;
	}

    public void setClickedLevel()
    {
        clickedLevel = !clickedLevel;
    }


	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
            Application.LoadLevel("WelcomeMenu");
	}

    public void PlayGame()
    {
        Application.LoadLevel("lv"+level);
    }
}