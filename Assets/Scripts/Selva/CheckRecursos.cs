using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckRecursos : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        if(Globales.madera>6 && Globales.suministros>1 && Globales.vacunas>0){
            Globales.checkRecursosSelva="false";
        } else {
            if(!Globales.clinicareparada){
                Globales.checkRecursosSelva="true";
            }
        }
    }
}
