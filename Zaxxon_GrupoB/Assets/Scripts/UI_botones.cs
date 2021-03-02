using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI_botones : MonoBehaviour
{
    public void Inicio()
    {
        SceneManager.LoadScene("zaxxon_scene1");
    }

    public void Highscore()
    {
        SceneManager.LoadScene("Highscore");
    }

     
    public void  Opciones()
    {
        SceneManager.LoadScene("");
    }
}
