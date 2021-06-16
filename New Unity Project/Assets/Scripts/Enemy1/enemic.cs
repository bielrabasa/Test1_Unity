using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemic : MonoBehaviour
{
    // Start is called before the first frame update
     void Update()
    {
       gameObject.transform.parent.Translate(0, -1f * Time.deltaTime, 0);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "ground")
        {
            Destroy(transform.parent.gameObject);
        }
        else if (other.gameObject.tag == "Player")
        {
            Destroy(transform.parent.gameObject);
        }
    }
}
