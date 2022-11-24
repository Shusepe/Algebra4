using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuertaHb1a2Script : MonoBehaviour
{
    public GameObject habitacion1;
    public GameObject habitacion2;

    void OnTriggerEnter(Collider collision)
    {
        Vector3 Hb1Position;
        Quaternion Hb1Rotation;

        Vector3 Hb2Position;

        Hb1Position = new Vector3(0.0f, 3.0f, 9.75f);
        Hb1Rotation = Quaternion.Euler(0.0f, 180.0f, 0.0f);

        Hb2Position = new Vector3(10.0f, 3.0f, 0.0f);

        if (collision.tag == "camBox")
        {
            if (GameObject.FindGameObjectWithTag("Habitacion3"))
            {
                Destroy(GameObject.FindGameObjectWithTag("Habitacion3"));
            }

            if (GameObject.FindGameObjectWithTag("Habitacion4"))
            {
                Destroy(GameObject.FindGameObjectWithTag("Habitacion4"));
            }


            if (!GameObject.FindGameObjectWithTag("Habitacion2"))
            {
                Instantiate(habitacion2, Hb2Position, transform.rotation);

                Destroy(GameObject.FindGameObjectWithTag("Habitacion3"));
            }
            
            if (!GameObject.FindGameObjectWithTag("Habitacion1")) 
            {
                Instantiate(habitacion1, Hb1Position, Hb1Rotation);

                Destroy(GameObject.FindGameObjectWithTag("Habitacion4"));
            }
        }
    }

    //if ((cameraEsEnHabitacion || collisionAtras) && GameObject.find("Habitacion1")) 
    //{
    //Instanciate(Habitacion1)
    //}
    //else if (GameObject.find("Habitacion1"))
    //{
    //    Destroy(Habitacion1)
    //}

    //if ((cameraEsEnHabitacion || collisionAtras) && GameObject.find("Habitacion2"))
    //{
    //    Instanciate(Habitacion2)
    //}
    //else if (GameObject.find("Habitacion2"))
    //{
    //    Destroy(Habitacion2)
    //}

void Update()
    {

    }
}
