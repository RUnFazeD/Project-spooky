using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blkscreenenablerbed : MonoBehaviour
{

    public GameObject blkscreen;


    
    private bool inReach;
    





    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            inReach = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            inReach = false;
        }
    }

    void Start()
    {
        inReach = false;
        blkscreen.SetActive(false);
    }




    void Update()
    {
        if (inReach && Input.GetButtonDown("Interact"))
        {
            blkscreen.SetActive(true);
        }

    }


}
