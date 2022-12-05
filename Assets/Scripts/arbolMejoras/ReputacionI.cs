using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReputacionI : Talent
{
    public override void Inicializar(){
        actual=Globales.Reputacion1;
    }
    public override bool Click(){
        if(base.Click()){
            Globales.REPUTACION+=0.1f;
            Debug.Log(Globales.REPUTACION);
            Globales.Reputacion1++;
            return true;
        }
        return false;
    }
    public override float coste(){
        return 800.0f;//preecio de la mejora
    }
    public override bool estadoLock(){
        return Globales.UnlockedReputacion1;
    }
    public override void setUnlockState(){
        Globales.UnlockedReputacion1=true;
    }
}
