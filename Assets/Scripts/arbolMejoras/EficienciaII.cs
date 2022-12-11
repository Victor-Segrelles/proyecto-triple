using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EficienciaII : Talent
{
    public override void Inicializar(){
        actual=Globales.Eficiencia2;
    }
    public override bool Click(){
        if(base.Click()){
            Globales.EFICIENCIA+=1.5f;
            Debug.Log(Globales.EFICIENCIA);
            Globales.Eficiencia2++;
            return true;
        }
        return false;
    }
    public override float coste(){
        return 1400.0f;//preecio de la mejora
    }
    public override bool estadoLock(){
        return Globales.UnlockedEficiencia2;
    }
    public override void setUnlockState(){
        Globales.UnlockedEficiencia2=true;
    }
}
