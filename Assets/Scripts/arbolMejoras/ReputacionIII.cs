using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReputacionIII : Talent
{
    public override bool Click(){
        if(base.Click()){
            Globales.REPUTACION+=10.5f;
            Debug.Log(Globales.REPUTACION);
            return true;
        }
        return false;
    }
    public override float coste(){
        return 2400.0f;//preecio de la mejora
    }
}
