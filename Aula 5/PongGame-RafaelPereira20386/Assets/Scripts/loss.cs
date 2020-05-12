using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loss : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision) {

        if (collision.gameObject.CompareTag("BallTag")) {
            GameObject.Find("ball").GetComponent<ball>().Reset();
            GameObject.Find("gameManagerObj").GetComponent<manager>().Reset();
            GameObject.Find("paddle").GetComponent<paddle>().Reset();
        }
    }
}
