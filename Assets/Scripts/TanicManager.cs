using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TanicManager : MonoBehaviour
{
    public GameObject TanicSelva;
    public GameObject TanicDesierto;
    // Start is called before the first frame update
    void Start()
    {
        if(Globales.cinematicavista == "false")
        {
            TanicDesierto.SetActive(true);
            TanicSelva.SetActive(false);
        }
        else
        {
            TanicDesierto.SetActive(false);
            TanicSelva.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
