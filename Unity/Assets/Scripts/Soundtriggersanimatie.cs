using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soundtriggersanimatie : MonoBehaviour
{

    public GameObject Collider;
    public GameObject Soundplace;


    private bool inReach;
    


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            inReach = true;
            Collider.SetActive(true);
            Soundplace.SetActive(true);

        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            inReach = false;
            Collider.SetActive(false);
            Soundplace.SetActive(true);
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
