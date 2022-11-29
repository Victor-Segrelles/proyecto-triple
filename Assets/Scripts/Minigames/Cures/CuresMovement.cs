using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuresMovement : MonoBehaviour
{
    //Este código se encuentra en el prefab del objeto
    private float velocidad = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.CompareTag("Arriba"))
            transform.position += Time.deltaTime * velocidad * Vector3.up;
        else
            transform.position += Time.deltaTime * velocidad * Vector3.down;
    }
}
