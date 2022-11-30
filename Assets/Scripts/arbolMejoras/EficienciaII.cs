using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EficienciaII : Talent
{
    public override bool Click(){
        if(base.Click()){
            Globales.EFICIENCIA+=1.5f;
            Debug.Log(Globales.EFICIENCIA);
            return true;
        }
        return false;
    }
    public override float coste(){
        return 1400.0f;//preecio de la mejora
    }
}
