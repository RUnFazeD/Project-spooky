using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartingScreenIcons : MonoBehaviour
{
    public GameObject startingScreen;
    public GameObject quack;

    public float waitTime;


    void Start()
    {
        startingScreen.SetActive(true);
        quack.SetActive(true);
        StartCoroutine(Starting());
    }

    IEnumerator Starting()
    {
        yield return new WaitForSeconds(waitTime);
        startingScreen.SetActive(false);

    }




    void Update()
    {
        
    }
}
