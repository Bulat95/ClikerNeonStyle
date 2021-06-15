using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRoad : MonoBehaviour
{
    private float offset = 0.2f;

    void Update()
    {
        transform.position = new Vector3(0,0, transform.position.z + offset); 
    }
}
