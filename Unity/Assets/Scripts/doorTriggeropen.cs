using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorTriggeropen : MonoBehaviour
{

    public GameObject Doorclosed;
    public GameObject Dooropen;
    public GameObject Collider;


    private bool inReach;


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            inReach = true;
            Collider.SetActive(true);
            Doorclosed.SetActive(true);
            Dooropen.SetActive(false);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            inReach = false;
            Collider.SetActive(false);
            Doorclosed.SetActive(false);
            Dooropen.SetActive(true);
        }
    }

    void Start()
    {
        inReach = false;
        Collider.SetActive(true);
        Doorclosed.SetActive(true);
        Dooropen.SetActive(false);
    }




    void Update()
    {
        
    }

}
