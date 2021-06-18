using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager scoreManager;
    public Text scoreText;
    int score = 0;
    void Start()
    {
        if (scoreManager == null)
        {
            scoreManager = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(this);
        }
    }
    void Update()
    {
        if (scoreText == null)//Todo el if entero se usa para pasar la puntuacion de una escena a otra.
        {
            scoreText = GameObject.Find("Text").GetComponent<Text>();//Todo el problema del GameObject.Find es por poner la g en minuscula, si quieres usar el .Find usa G mayuscula.
            scoreText.text = score + "";
        }
    }
    public void RaiseScore(int s)
    {
        score += s;
        Debug.Log(score);
        scoreText.text = score + "";
        if(score== 3)
        {
            SceneManager.LoadScene("Scene2");
        }
        if (score == 20)//Funciona mal y te manda a una escena diferente pero aparece la puntuacion en pantalla en vez del texto predefinido.
        {
            SceneManager.LoadScene("SceneWin");
        }
    }
}

