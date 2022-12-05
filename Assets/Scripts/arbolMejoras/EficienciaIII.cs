using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EficienciaIII : Talent
{
    public override void Inicializar(){
        actual=Globales.Eficiencia3;
    }
    public override bool Click(){
        if(base.Click()){
            Globales.EFICIENCIA+=10.5f;
            Debug.Log(Globales.EFICIENCIA);
            Globales.Eficiencia3++;
            return true;
        }
        return false;
    }
    public override float coste(){
        return 2400.0f;//preecio de la mejora
    }
    public override bool estadoLock(){
        return Globales.UnlockedEficiencia3;
    }
    public override void setUnlockState(){
        Globales.UnlockedEficiencia3=true;
    }
}
