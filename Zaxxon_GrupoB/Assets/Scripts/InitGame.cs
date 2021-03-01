using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InitGame : MonoBehaviour
{
    public Text textoInicial;
    // Start is called before the first frame update
    void Start()
    {
        textoInicial.text = "chan";
        textoInicial.color = Color.blue;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
