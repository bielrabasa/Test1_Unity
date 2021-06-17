using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coincontroller : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            ScoreManager.scoreManager.RaiseScore(1);
            Destroy(transform.parent.gameObject);
        }
    }


}


