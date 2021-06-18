using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    float timer;
    public GameObject Enemy1Prefab;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 2f)
        {
            timer = 0;
            float x = Random.Range(-17f, 17f);
            Vector3 position = new Vector3(x, 12, 0);//PROBAR ESTE CODIDO para la posicion x:"Hace que la posicion de spawn de el punto no sea aleatorio sino que spawnee a una distancia en concreto del perosnaje" = GameObject.Find("Player").transform.position.x+20; 
            Quaternion rotation = new Quaternion();
            Instantiate(Enemy1Prefab, position, rotation);

        }

    }
}
