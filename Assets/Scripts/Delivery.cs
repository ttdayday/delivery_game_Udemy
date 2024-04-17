using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage;

    private void Start()
    {
        Debug.Log(hasPackage);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Ouch!");
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Package")
        {
            Debug.Log("Package picked up");
            hasPackage = true;
            other.gameObject.SetActive(false);
        }
        if (other.tag == "Customer" && hasPackage)
        {
            Debug.Log("Package dropped off");
            hasPackage = false;
        }

    }

}
