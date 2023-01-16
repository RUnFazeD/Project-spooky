﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Screentoblackdungeon1 : MonoBehaviour
{
    public GameObject blkscreen;

    public float waitTime;


    void Start()
    {
        blkscreen.SetActive(false);
    }


    void Update()
    {
        if (blkscreen.activeInHierarchy)
        {
            StartCoroutine(Starting());
        }

    }
    IEnumerator Starting()
    {
        yield return new WaitForSeconds(waitTime);
        SceneManager.LoadScene("Clean Bedroom");

    }
}