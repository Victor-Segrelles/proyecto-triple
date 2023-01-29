using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkRecursos2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        if(Globales.DINERO>=3000 && Globales.suministros>4){
            Globales.checkRecursosCiudad="false";
        } else {
            if(!Globales.ciudadreparada){
                Globales.checkRecursosCiudad="true";
            }
        }
    }
}
