using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objectpickup : MonoBehaviour
{ 


    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Book")
        {
            Debug.Log("Collision Has occured");
            Destroy(collision.gameObject);
            Debug.Log("Book has been picked up");
        }
    }
}
