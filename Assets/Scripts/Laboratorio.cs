using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laboratorio : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if(Globales.cinematicavista == "true")
        {
            gameObject.SetActive(false);
        }
        else
        {
            gameObject.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
