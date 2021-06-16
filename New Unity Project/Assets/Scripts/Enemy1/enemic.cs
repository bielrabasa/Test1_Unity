using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemic : MonoBehaviour
{
    // Start is called before the first frame update
     void Update()
    {
       gameObject.transform.Translate(0, -1f * Time.deltaTime, 0);
        //if(gameObject)
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(transform.parent.gameObject);
    }
}
