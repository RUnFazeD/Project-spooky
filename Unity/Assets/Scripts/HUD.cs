using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUD : MonoBehaviour
{

    public GameObject Lighter;
    public GameObject LighterOB;

    public GameObject Key;
    public GameObject KeyOB;




    void Start()
    {
        Lighter.SetActive(true);
        
    }




    void Update()
    {
        if (LighterOB.activeInHierarchy)
        {
            Lighter.SetActive(true);
        }

        else
        {
            Lighter.SetActive(false);
        }

        if (KeyOB.activeInHierarchy)
        {
            Key.SetActive(true);
        }

        else
        {
            Key.SetActive(false);
        }
    }
}
