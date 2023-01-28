using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class muroinvisible : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private GameObject muro;
    void Start()
    {
        if(Globales.tiendaCinematica){
            muro.SetActive(true);
        } else {
            muro.SetActive(false);
        }
    }
}
