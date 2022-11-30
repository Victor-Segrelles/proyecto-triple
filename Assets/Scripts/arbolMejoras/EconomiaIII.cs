using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EconomiaIII : Talent
{
    public override bool Click(){
        if(base.Click()){
            Globales.ECONOMIA+=10.5f;
            Debug.Log(Globales.ECONOMIA);
            return true;
        }
        return false;
    }
    public override float coste(){
        return 2400.0f;//preecio de la mejora
    }
}
