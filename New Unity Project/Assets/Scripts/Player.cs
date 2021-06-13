using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(input.Get)

            gameObject.GetComponent<Transform>().position = new Vector3(gameObject.GetComponent<Transform>().position.x + 1f * Time.deltaTime, gameObject.GetComponent<Transform>().position.y, gameObject.GetComponent<Transform>().position.z);
        gameObject.transform.Translate(50f * Time.deltaTime, 0, 0);
    }
}
