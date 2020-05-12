using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goal : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision) {

        if (collision.gameObject.CompareTag("BallTag")) {
            GameObject.Find("gameManagerObj").GetComponent<manager>().Player1Scored();
        }        
    }
}
