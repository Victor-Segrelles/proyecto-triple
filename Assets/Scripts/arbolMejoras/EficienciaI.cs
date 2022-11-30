using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EficienciaI : Talent
{
    public override bool Click(){
        if(base.Click()){
            Globales.EFICIENCIA+=0.1f;
            Debug.Log(Globales.EFICIENCIA);
            return true;
        }
        return false;
    }
    public override float coste(){
        return 800.0f;//preecio de la mejora
    }
}
