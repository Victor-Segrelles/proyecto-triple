using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HieloManager : MonoBehaviour
{
    public GameObject congelado1;
    public GameObject congelado2;
    public GameObject liberado1;
    public GameObject liberado2;
    // Start is called before the first frame update
    void Start()
    {
        if(Globales.hielofinal == "true")
        {
            liberado1.SetActive(false);
            liberado2.SetActive(false);
            congelado1.SetActive(true);
            congelado2.SetActive(true);
        }
        else
        {
            liberado1.SetActive(true);
            liberado2.SetActive(true);
            congelado1.SetActive(false);
            congelado2.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
