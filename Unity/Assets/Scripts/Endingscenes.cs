using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Endingscenes : MonoBehaviour
{
    public GameObject textOB;

    public bool inReach;
    public float waitTime;


    void Start()
    {
        textOB.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            inReach = true;
            textOB.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            inReach = false;
            textOB.SetActive(false);
        }
    }

    void Update()
    {
        if (inReach && Input.GetButtonDown("Interact"))
        {
            textOB.SetActive(false);
            StartCoroutine(Starting());
        }   

    }
    IEnumerator Starting()
    {
        yield return new WaitForSeconds(waitTime);
        SceneManager.LoadScene("Titlescreen");

    }
}
