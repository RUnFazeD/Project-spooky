using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleLook : MonoBehaviour
{
    public GameObject Particle;

    public bool inReach;


    void Start()
    {
        inReach = false;
        Particle.SetActive(true);
    }



    void Update()
    {
        if (inReach && Input.GetButtonDown("Interact"))
        {
            Particle.SetActive(false);
        }

        
    }
}
