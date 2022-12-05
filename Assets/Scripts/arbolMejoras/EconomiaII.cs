using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EconomiaII : Talent
{
    public override void Inicializar(){
        actual=Globales.Economia2;
    }
    public override bool Click(){
        if(base.Click()){
            Globales.ECONOMIA+=1.5f;
            Debug.Log(Globales.ECONOMIA);
            Globales.Economia2++;
            return true;
        }
        return false;
    }
    public override float coste(){
        return 1400.0f;//preecio de la mejora
    }
    public override bool estadoLock(){
        return Globales.UnlockedEconomia2;
    }
    public override void setUnlockState(){
        Globales.UnlockedEconomia2=true;
    }
}
