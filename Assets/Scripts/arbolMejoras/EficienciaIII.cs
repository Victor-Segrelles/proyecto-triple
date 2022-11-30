using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EficienciaIII : Talent
{
    public override bool Click(){
        if(base.Click()){
            Globales.EFICIENCIA+=10.5f;
            Debug.Log(Globales.EFICIENCIA);
            return true;
        }
        return false;
    }
    public override float coste(){
        return 2400.0f;//preecio de la mejora
    }
}
