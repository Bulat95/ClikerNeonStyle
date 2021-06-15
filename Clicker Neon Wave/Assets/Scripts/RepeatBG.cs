using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBG : MonoBehaviour
{
    
    public float horizontalSize;
    private Vector3 _offsetForvard;

    void Update()
    {
        if (transform.position.z > -horizontalSize)
            RepeatBackground();
    }

    private void RepeatBackground()
    {
        _offsetForvard = new Vector3(0, 0, horizontalSize);
        transform.position = transform.position + _offsetForvard;
    }
}

