using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartInactive : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false); //Para desactivar todos los objetos de primeras
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
