using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorialtext : MonoBehaviour
{

    public GameObject Tutorial;
    public GameObject Collider;
    public GameObject NextTutorial;

    private bool inReach;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            inReach = true;
            Tutorial.SetActive(false);
            NextTutorial.SetActive(false);
        }
    }


    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            inReach = false;
            Tutorial.SetActive(false);
            NextTutorial.SetActive(true);
        }
    }
    void Start()
    {
        inReach = false;
        Tutorial.SetActive(true);
        NextTutorial.SetActive(false);
    }

void Update()
    {

    }
}
