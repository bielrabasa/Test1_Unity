using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LifeManager : MonoBehaviour
{
    public static LifeManager lifeManager;
    public Text lifeText;
    int life = 5;
    // Start is called before the first frame update
    void Start()
    {
        lifeManager = this;
    }

    // Update is called once per frame
    public void RaiseLife(int s)
    {
        life -= s;
        Debug.Log(life);
        lifeText.text = life + "";
    }
    public bool Life1()
    {
        if (life <= 0)
        {
            return true;

        }
        else
        {
            return false;
        }
    }
}
