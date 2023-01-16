using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorialtextsingle : MonoBehaviour
{

    public GameObject Tutorial;
    public GameObject Collider;
    public GameObject Tutorialdisable;

    private bool inReach;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            inReach = true;
            Tutorial.SetActive(false);
            Tutorialdisable.SetActive(false);
        }
    }


    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            inReach = false;
            Tutorial.SetActive(true);
            Tutorialdisable.SetActive(false);
        }
    }
    void Start()
    {
        inReach = false;
        Tutorial.SetActive(false);
        Tutorialdisable.SetActive(false);
    }

void Update()
    {

    }
}
