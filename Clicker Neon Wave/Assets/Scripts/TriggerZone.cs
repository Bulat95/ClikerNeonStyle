using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZone : MonoBehaviour
{

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Road")
        {
            other.transform.position = new Vector3(0, 0, 0);
        }
    }

    //private void OnCollisionEnter(Collision collision)
    //{
    //    if(collision.collider.CompareTag("Road"))
    //    {
    //        collision.transform.position = new Vector3(0, 0, 0);
    //    }
    //}

    //private void OnTriggerEnter(Collider other)
    //{
    //    if(other.tag == "Road")
    //    {
    //        other.transform.position = new Vector3(0, 0, 0);
    //    }
    //}
}
