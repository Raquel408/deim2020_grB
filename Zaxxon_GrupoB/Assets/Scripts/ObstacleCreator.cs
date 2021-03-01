using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCreator : MonoBehaviour
{
    //---SCRIPT ASOCIADO AL EMPTY OBJECT QUE CREARÁ LOS OBSTÁCULOS--//

    //Variable que contendré el prefab con el obstáculo
    [SerializeField] GameObject Columna;

    //Variable que tiene la posición del objeto de referencia
    [SerializeField] Transform InitPos;

    //Variables para generar columnas de forma random
    private float randomNumber;
    Vector3 RandomPos;

    //Distancia entre columnas
    float distanciaSep = 6f;

    //Acceder a los componentes de la nave
    public GameObject Nave;
    private SpaceshipMove spaceshipMove;

    // Start is called before the first frame update
    void Start()
    {

        //Accedo al script de la nave
        spaceshipMove = Nave.GetComponent<SpaceshipMove>();

        //Creo las columnas iniciales
        for (int n = 1; n <= 10; n++)
        {

            //Creamos cada columna, con la separación establecida
            CrearColumna(-n * distanciaSep);
        }


        //Lanzo la corrutina
        StartCoroutine("InstanciadorColumnas");

    }

    //Función que crea una columna en una posición Random
    //Lo hemos cambiado para que se le pueda pasar el valor en X (0 por defecto)
    void CrearColumna(float posZ = 0f)
    {
        randomNumber = Random.Range(0f, 14f);
        RandomPos = new Vector3(randomNumber, 0, posZ);
        //print(RandomPos);
        Vector3 FinalPos = InitPos.position + RandomPos;
        Instantiate(Columna, FinalPos, Quaternion.identity);
    }

    //Corrutina que se ejecuta cada segundo
    //NOTA: ahora el intervalo de la corrutina depende de la variable "speed" de la nave
    //Aplicamos la fórmula "espacioEntreColumnas / velocidad"
    IEnumerator InstanciadorColumnas()
    {
        //Bucle infinito (poner esto es lo mismo que while(true){}
        for (; ; )
        {
            CrearColumna();
            float interval = distanciaSep / spaceshipMove.speed;
            yield return new WaitForSeconds(1f);
        }

    }


}
