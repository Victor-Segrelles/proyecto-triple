using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EconomiaI : Talent
{
    public override bool Click(){
        if(base.Click()){
            Globales.ECONOMIA+=0.1f;
            Debug.Log(Globales.ECONOMIA);
            return true;
        }
        return false;
    }
    public override float coste(){
        return 800.0f;//preecio de la mejora
    }
}
