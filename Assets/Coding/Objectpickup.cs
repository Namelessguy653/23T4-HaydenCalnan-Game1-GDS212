using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Objectpickup : MonoBehaviour
{
    private int score;
    public TextMeshProGUI scoreText;

    void Start()
    {
        score = 0;
        scoreText.text = "Score: " + score;
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Book")
        {
            Debug.Log("Collision Has occured");
            Destroy(collision.gameObject);
            Debug.Log("Book has been picked up");
            score = ++1;
            Debug.Log("Score has been increased");
        }
    }
}
