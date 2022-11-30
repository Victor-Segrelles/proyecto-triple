using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReputacionII : Talent
{
    public override bool Click(){
        if(base.Click()){
            Globales.REPUTACION+=1.5f;
            Debug.Log(Globales.REPUTACION);
            return true;
        }
        return false;
    }
    public override float coste(){
        return 1400.0f;//preecio de la mejora
    }
}
