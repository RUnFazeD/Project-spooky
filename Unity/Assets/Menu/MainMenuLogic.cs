using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuLogic : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject extrasMenu;
    public GameObject loading;
    public GameObject Intro;
    public GameObject Video;
    public GameObject MainText;
    public GameObject buttons;
    public GameObject mainmenumusic;

    public float waitTime;

    public AudioSource buttonSound;
    public AudioSource TapeInsert;


    void Start()
    {
        Intro.SetActive(true);
        MainText.SetActive(false);
        TapeInsert.Play();
        mainmenumusic.SetActive(false);
        Video.SetActive(false);
        buttons.SetActive(false);
        mainMenu.GetComponent<Canvas>().enabled = true;
        extrasMenu.GetComponent<Canvas>().enabled = false; 
        loading.GetComponent<Canvas>().enabled = false;
        StartCoroutine(Starting());
    }
    
    IEnumerator Starting()
    {
        yield return new WaitForSeconds(waitTime);
        Intro.SetActive(false);
        Video.SetActive(true);
        MainText.SetActive(true);
        buttons.SetActive(true);
        mainmenumusic.SetActive(true);
    }

    public void StartButton()
    {
        loading.GetComponent<Canvas>().enabled = true;
        Intro.SetActive(true);
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
