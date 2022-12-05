using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReputacionII : Talent
{
    public override void Inicializar(){
        actual=Globales.Reputacion2;
    }
    public override bool Click(){
        if(base.Click()){
            Globales.REPUTACION+=1.5f;
            Debug.Log(Globales.REPUTACION);
            Globales.Reputacion2++;
            return true;
        }
        return false;
    }
    public override float coste(){
        return 1400.0f;//preecio de la mejora
    }
    public override bool estadoLock(){
        return Globales.UnlockedReputacion2;
    }
    public override void setUnlockState(){
        Globales.UnlockedReputacion2=true;
    }
}
