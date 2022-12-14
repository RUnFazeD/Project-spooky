using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponsSwitch : MonoBehaviour
{
    public GameObject object01;
    public GameObject object02;
    public GameObject Keyneeded;
    public GameObject keyui;
    public GameObject LighterUI;

    void Start()
    {
        object01.SetActive(true);
        object02.SetActive(false);
        keyui.SetActive(false);
        LighterUI.SetActive(true);
    }




    void Update()
    {

        if (Input.GetButtonDown("1"))
        {
            object01.SetActive(true);
            object02.SetActive(false);
            keyui.SetActive(false);
            LighterUI.SetActive(true);
        }

        if(Keyneeded.activeInHierarchy && Input.GetButtonDown("2"))
        {
            object01.SetActive(false);
            object02.SetActive(true);
            keyui.SetActive(true);
            LighterUI.SetActive(false);
        }

    }
}
