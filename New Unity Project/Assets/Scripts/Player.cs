using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    bool canjump;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Start is called before the first frame update


        // Update is called once per frame

        if (Input.GetKey("a"))
        {
            gameObject.transform.Translate(-50f * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("d"))
        {
            gameObject.transform.Translate(50f * Time.deltaTime, 0, 0);
        }
        ManageJump();
    }
    void ManageJump()
    {
        if (gameObject.transform.position.y <= 0)
        {
            canjump = true;
        }
        if (Input.GetKey(KeyCode.Space) && canjump && gameObject.transform.position.y < 10)
        {
            gameObject.transform.Translate(0, 50f * Time.deltaTime, 0);
        }
        else
        {
            canjump = false;
            if (gameObject.transform.position.y > 0)
            {
                gameObject.transform.Translate(0, -50f * Time.deltaTime, 0);
            }
        }

    }
}
    
