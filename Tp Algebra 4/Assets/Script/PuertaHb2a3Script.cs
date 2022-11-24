using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuertaHb2a3Script : MonoBehaviour
{
    public GameObject habitacion2;
    public GameObject habitacion3;

    void OnTriggerEnter(Collider collision)
    {
        Vector3 Hb2Position;
        Vector3 Hb3Position;

        Hb2Position = new Vector3(10.0f, 3.0f, 0.0f);
        Hb3Position = new Vector3(20.0f, 3.0f, 0.0f);

        if (collision.tag == "camBox")
        {
            if (GameObject.FindGameObjectWithTag("Habitacion1"))
            {
                Destroy(GameObject.FindGameObjectWithTag("Habitacion1"));
            }

            if (GameObject.FindGameObjectWithTag("Habitacion4"))
            {
                Destroy(GameObject.FindGameObjectWithTag("Habitacion4"));
            }


            if (!GameObject.FindGameObjectWithTag("Habitacion3"))
            {
                Instantiate(habitacion3, Hb3Position, transform.rotation);

                Destroy(GameObject.FindGameObjectWithTag("Habitacion1"));
            }
            
            if (!GameObject.FindGameObjectWithTag("Habitacion2")) 
            {
                Instantiate(habitacion2, Hb2Position, transform.rotation);

                Destroy(GameObject.FindGameObjectWithTag("Habitacion4"));
            }
        }
    }
    
    void Update()
    {

    }
}
