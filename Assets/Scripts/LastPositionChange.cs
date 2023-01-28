using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastPositionChange : MonoBehaviour
{
    public Vector3 posicion;
    // Start is called before the first frame update
    void Start()
    {
        Globales.lastPosition = posicion;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
