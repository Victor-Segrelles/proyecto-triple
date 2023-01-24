using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReputacionIII : Talent
{
    public override void Inicializar(){
        actual=Globales.Reputacion3;
    }
    public override bool Click(){
        if(base.Click()){
            Globales.REPUTACION+=2.5f;
            Debug.Log(Globales.REPUTACION);
            Globales.Reputacion3++;
            return true;
        }
        return false;
    }
    public override float coste(){
        return 2400.0f;//preecio de la mejora
    }
    public override bool estadoLock(){
        return Globales.UnlockedReputacion3;
    }
    public override void setUnlockState(){
        Globales.UnlockedReputacion3=true;
    }
}
