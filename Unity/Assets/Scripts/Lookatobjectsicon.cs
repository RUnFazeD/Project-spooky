using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lookatobjectsicon : MonoBehaviour
{

    public GameObject IconOB;

    private bool inReach;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            inReach = true;
            IconOB.SetActive(true);
        }
    }


    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            inReach = false;
            IconOB.SetActive(false);
        }
    }
    void Start()
    {
        inReach = false;
        IconOB.SetActive(false);
    }

void Update()
    {
        if (inReach && Input.GetButtonDown("Interact"))
        {
            IconOB.SetActive(false);
        }

        
    }
}
