using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blscreenenabler : MonoBehaviour
{
    public GameObject blkscreen;

    private bool inReach;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            inReach = true;
            blkscreen.SetActive(true);
        }
    }


    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            inReach = false;
            blkscreen.SetActive(true);
        }
    }
    void Start()
    {
        inReach = false;
        blkscreen.SetActive(false);
    }

void Update()
    {

    }
}
