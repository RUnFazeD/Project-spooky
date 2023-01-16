using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soundtriggersdisable : MonoBehaviour
{

    public GameObject Collider;
    public GameObject Colliderdisabled;
    public GameObject Soundplace;


    private bool inReach;
    


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Reach" && Colliderdisabled.activeInHierarchy)
        {
            inReach = true;
            Collider.SetActive(true);
            Soundplace.SetActive(false);

        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            inReach = false;
            Collider.SetActive(false);
            Soundplace.SetActive(false);
        }
    }

    void Start()
    {
        inReach = false;
        Collider.SetActive(true);
        Soundplace.SetActive(false);
    }




    void Update()
    {
        
    }

}
