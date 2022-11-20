using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrowMovement : MonoBehaviour
{
    public float velocidadFlecha;
    public SpriteRenderer barra;
    private Vector3 direccion;
    
    // Start is called before the first frame update
    void Start()
    {
        direccion = Vector3.up;
    }

    // Update is called once per frame <>
    void Update()
    {
        //Debug.Log(mediaFlecha);
        if (transform.position.y>= barra.bounds.size.y/2)
        {
            direccion = Vector3.down;
        }
        else if (transform.position.y<= 0 - barra.bounds.size.y/2)
        {
            direccion = Vector3.up;
        }
        transform.position += Time.deltaTime * velocidadFlecha * direccion;
    }
}
