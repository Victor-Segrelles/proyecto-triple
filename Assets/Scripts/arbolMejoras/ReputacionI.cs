using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReputacionI : Talent
{
    public override bool Click(){
        if(base.Click()){
            Globales.REPUTACION+=0.1f;
            Debug.Log(Globales.REPUTACION);
            return true;
        }
        return false;
    }
    public override float coste(){
        return 800.0f;//preecio de la mejora
    }
}
