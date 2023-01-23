using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiendaManager : MonoBehaviour
{
    private float subtotal=0.0f;
    private int madera=0;
    private int vacunas=0;
    private int tiritas=0;
    private int suministros=0;

    public void OnMaderaPlus(){
        madera++;
        updatetexts();
    }
    public void OnMaderaMin(){
        if(madera>0){
            madera--;
            updatetexts();
        }
    }
    public void OnVacunaPlus(){
        vacunas++;
        updatetexts();
    }
    public void OnVacunaMin(){
        if(vacunas>0){
            vacunas--;
            updatetexts();
        }
    }
    public void OnTiritaPlus(){
        tiritas++;
        updatetexts();
    }
    public void OnTiritaMin(){
        if(tiritas>0){
            tiritas--;
            updatetexts();
        }
    }
    public void OnSuministrosPlus(){
        suministros++;
        updatetexts();
    }
    public void OnSuministrosMin(){
        if(suministros>0){
            suministros--;
            updatetexts();
        }
    }

    private void updatetexts(){

    }
    public void OnCompra(){

    }
    public void OnVenta(){

    }
}
