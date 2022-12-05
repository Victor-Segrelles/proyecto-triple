using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EficienciaI : Talent
{
    public override void Inicializar(){
        actual=Globales.Eficiencia1;
    }
    public override bool Click(){
        if(base.Click()){
            Globales.EFICIENCIA+=0.1f;
            Debug.Log(Globales.EFICIENCIA);
            Globales.Eficiencia1++;
            return true;
        }
        return false;
    }
    public override float coste(){
        return 800.0f;//preecio de la mejora
    }
    public override bool estadoLock(){
        return Globales.UnlockedEficiencia1;
    }
    public override void setUnlockState(){
        Globales.UnlockedEficiencia1=true;
    }
}
