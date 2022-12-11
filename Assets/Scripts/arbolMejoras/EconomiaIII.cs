using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EconomiaIII : Talent
{
    public override void Inicializar(){
        actual=Globales.Economia3;
    }
    public override bool Click(){
        if(base.Click()){
            Globales.ECONOMIA+=10.5f;
            Debug.Log(Globales.ECONOMIA);
            Globales.Economia3++;
            return true;
        }
        return false;
    }
    public override float coste(){
        return 2400.0f;//preecio de la mejora
    }
    public override bool estadoLock(){
        return Globales.UnlockedEconomia3;
    }
    public override void setUnlockState(){
        Globales.UnlockedEconomia3=true;
    }
}
