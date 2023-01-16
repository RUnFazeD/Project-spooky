using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soundtriggersdungeon2 : MonoBehaviour
{

    public GameObject Collider;
    public GameObject Colliderdisabled;
    public GameObject Soundplace;


    private bool inReach;
    


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            inReach = true;
            Collider.SetActive(true);
            Soundplace.SetActive(true);
            Colliderdisabled.SetActive(false);

        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            inReach = false;
            Collider.SetActive(false);
            Soundplace.SetActive(true);
            Colliderdisabled.SetActive(true);
        }
    }

    void Start()
    {
        inReach = false;
        Collider.SetActive(true);
        Soundplace.SetActive(false);
        Colliderdisabled.SetActive(false);
    }




    void Update()
    {
        
    }

}
