using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuertaHb3a4Script : MonoBehaviour
{
    public GameObject habitacion3;
    public GameObject habitacion4;

    void OnTriggerEnter(Collider collision)
    {
        Vector3 Hb3Position;
        Vector3 Hb4Position;

        Quaternion Hb4Rotation;

        Hb3Position = new Vector3(20.0f, 3.0f, 0.0f);

        Hb4Position = new Vector3(25.1f, 3.0f, 14.8f);
        //Hb4Rotation = new Quaternion(0.0f, -90.0f, 0.0f);

        if (collision.tag == "camBox")
        {
            if (GameObject.FindGameObjectWithTag("Habitacion1"))
            { 
                 Destroy(GameObject.FindGameObjectWithTag("Habitacion1"));
                 Destroy(GameObject.FindGameObjectWithTag("Pared1a2"));
            }

            if (GameObject.FindGameObjectWithTag("Habitacion2"))
            {
                Destroy(GameObject.FindGameObjectWithTag("Habitacion2"));
            }


            if (!GameObject.FindGameObjectWithTag("Habitacion4"))
            {
                Instantiate(habitacion4, Hb4Position, transform.rotation);
            }
            
            if (!GameObject.FindGameObjectWithTag("Habitacion3")) 
            {
                Instantiate(habitacion3, Hb3Position, transform.rotation);
            }
        }
    }

    void Update()
    {

    }
}
