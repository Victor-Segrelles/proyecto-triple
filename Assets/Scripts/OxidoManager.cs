using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OxidoManager : MonoBehaviour
{
    public GameObject feliz1;
    public GameObject feliz2;
    public GameObject feliz3;
    public GameObject triste1;
    public GameObject triste2;
    public GameObject triste3;
    // Start is called before the first frame update
    void Start()
    {
        if(Globales.partir == "true")
        {
            feliz1.SetActive(false);
            feliz2.SetActive(false);
            feliz3.SetActive(false);
            triste1.SetActive(true);
            triste2.SetActive(true);
            triste3.SetActive(true);
        }
        else
        {
            feliz1.SetActive(true);
            feliz2.SetActive(true);
            feliz3.SetActive(true);
            triste1.SetActive(false);
            triste2.SetActive(false);
            triste3.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
