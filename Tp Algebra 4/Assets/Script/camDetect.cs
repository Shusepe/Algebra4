using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camDetect : MonoBehaviour
{

    public GameObject habitacion1;
    public GameObject habitacion2;
    public GameObject habitacion3;
    public GameObject habitacion4;

    void OnTriggerStay(Collider collision)
    {
        if (collision.tag == "PuertaHb1a2") 
        {
            Instantiate(habitacion2, transform.position, transform.rotation);
        }
    }

    //private void OnCollisionExit(Collision collision)
    //{
        
    //}

    void Update()
    {

    }
}
