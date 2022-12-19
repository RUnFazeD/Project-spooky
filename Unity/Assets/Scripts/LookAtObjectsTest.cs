using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LookAtObjectsTest : MonoBehaviour
{
    public GameObject IconOB;
    public TextMeshProUGUI textOB;
    public string description = "Description";

    public bool inReach;


    void Start()
    {
        textOB.GetComponent<TextMeshProUGUI>().enabled = false;
        IconOB.SetActive(false);
    }

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
            textOB.GetComponent<TextMeshProUGUI>().enabled = false;
            textOB.GetComponent<TextMeshProUGUI>().text = "";
        }
    }

    void Update()
    {
        if (inReach && Input.GetButtonDown("Interact"))
        {
            textOB.text = description.ToString();
            textOB.GetComponent<TextMeshProUGUI>().enabled = true;
        }   

    }
}
