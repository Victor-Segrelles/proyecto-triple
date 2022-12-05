using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EconomiaI : Talent
{
    public override void Inicializar(){
        actual=Globales.Economia1;
    }
    public override bool Click(){
        if(base.Click()){
            Globales.ECONOMIA+=0.1f;
            Debug.Log(Globales.ECONOMIA);
            Globales.Economia1++;
            return true;
        }
        return false;
    }
    public override float coste(){
        return 800.0f;//preecio de la mejora
    }
    public override bool estadoLock(){
        return Globales.UnlockedEconomia1;
    }
    public override void setUnlockState(){
        Globales.UnlockedEconomia1=true;
    }
}
