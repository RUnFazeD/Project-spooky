﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuLogic : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject extrasMenu;
    public GameObject loading;

    public AudioSource buttonSound;



    void Start()
    {

        mainMenu.GetComponent<Canvas>().enabled = true;
        extrasMenu.GetComponent<Canvas>().enabled = false; 
        loading.GetComponent<Canvas>().enabled = false; 
    }

    public void StartButton()
    {
        loading.GetComponent<Canvas>().enabled = true;
        mainMenu.GetComponent<Canvas>().enabled = false;
        buttonSound.Play();
        SceneManager.LoadScene("Royscriptprototype");
    }

    public void ExtrasButton()
    {
        buttonSound.Play();
        mainMenu.GetComponent<Canvas>().enabled = false;
        extrasMenu.GetComponent<Canvas>().enabled = true;
    }

    public void ExitGameButton()
    {
        buttonSound.Play();
        Application.Quit();
        Debug.Log("App Has Exited");
    }

    public void ReturnToMainMenuButton()
    {
        buttonSound.Play();
        mainMenu.GetComponent<Canvas>().enabled = true;
        extrasMenu.GetComponent<Canvas>().enabled = false;
    }



    void Update()
    {
        
    }
}
