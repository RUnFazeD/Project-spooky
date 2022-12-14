using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartingScreen : MonoBehaviour
{
    public GameObject startingScreen;

    public float waitTime;


    void Start()
    {
        startingScreen.SetActive(false);

        StartCoroutine(Starting());
    }

    IEnumerator Starting()
    {
        yield return new WaitForSeconds(waitTime);
        startingScreen.SetActive(true);
        
    }




    void Update()
    {
        
    }
}
