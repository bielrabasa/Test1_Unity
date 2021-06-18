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
        if (gameObject.transform.position.x == 20)//No va aun. Es para probar como hacer posicionamiento de objetos basado en el posicionamiento de otro.
        {
            Debug.Log("L");
        }
        if (GameObject.Find("Player").transform.position.x == 0)//Es posible que esta parte de codigo funcione a la hora de poder hacer que el disparo del personaje salga siempre desde la posicion x"en este caso" del personaje. Util tb para usar en disparos de enmigos o spawnear cosas a una distancia en concreto del Player o de cualquier otro objeto
        {
            Debug.Log("j");
        }
        // Start is called before the first frame update
        if (Input.GetKey(KeyCode.A))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-1000f * Time.deltaTime, 0));//Se usa para mover el personaje con fisica. En este caso lo mueves dandole una fuerza.
            gameObject.GetComponent<Animator>().SetBool("moving", true);//Se usa para activar la animacion del movimiento del personaje.
            gameObject.GetComponent<SpriteRenderer>().flipX = true;//Se usa para poder ver al personaje correctamente mientras se mueve hacia la direccion indicada sin que se vea del reves.
        }
        if (Input.GetKey(KeyCode.D))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(1000f * Time.deltaTime, 0));
            gameObject.GetComponent<Animator>().SetBool("moving", true);
            gameObject.GetComponent<SpriteRenderer>().flipX = false;

        }
        if (!Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D))
        {
            gameObject.GetComponent<Animator>().SetBool("moving", false);//En el momento en que no pulsas ninguna letra se pone en false y no se hace ninguna animacion "O una animacion de estar parado en caso de tenerla".

        }
        if (Input.GetKey(KeyCode.Space) && canjump)
        {
            canjump = false;
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 300f));//Para saltar usando el mismo procedimiento que en el movimiento lateral pero en este caso moviendo el eje y.
        }

        if (LifeManager.lifeManager.Life1())//Es usado para destruir el personaje una vez se muere y no tener memoria acumulatiba.
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "ground")//Va bien para detectar contra que esta colisionando y poder hacer diferentes funciones a partir de eso.
        {
            canjump = true;
        }
        if (collision.gameObject.tag == "Enemy1")
        {
           /* Debug.Log(life);
            life -= 1;
            LifeManager.lifeManager.RaiseLife(1);*/
        }

    }
}
    
