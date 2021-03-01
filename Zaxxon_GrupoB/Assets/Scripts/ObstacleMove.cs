using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMove : MonoBehaviour
{

    //Creamos la variable a la que se moverá el obtáculo
    //Este valor deberá depender de la velocidad de la nave
    private float obstacleSpeed;

    

    //Variables necesarias para acceder al script asociado a la nave
    public GameObject SpaceShip;

    //Cramos una variable de tipo clase pública "SpaceshipMove"
    SpaceshipMove spaceshipMove;

    // Start is called before the first frame update
    void Start()
    {
        //Como desde el prefab no podemos arrastrar el GameObject, lo buscamos en la escena
        SpaceShip = GameObject.Find("nave");
        //Asociamos a la variable el componente de la nave (es decir su script)
        spaceshipMove = SpaceShip.GetComponent<SpaceshipMove>();
    }

    // Update is called once per frame
    void Update()
    {
        
        //Comprobamos si la instancia ha rebasado a la nave y la destruimos
        //NOTA: habría que pasar esto a una CORRUTINA para consumir menos recursos
        float PosZ = transform.position.z;
        if(PosZ < -12)
        {
            Destroy(gameObject);
        }

        //Asignamos la velocidad que nos da el script de la nave (spaceshipMove)
        obstacleSpeed = spaceshipMove.speed;
       

        transform.Translate(Vector3.back * Time.deltaTime * obstacleSpeed);
    }
}
