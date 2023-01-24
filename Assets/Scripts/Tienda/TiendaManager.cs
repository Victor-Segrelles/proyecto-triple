using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TiendaManager : MonoBehaviour
{
    private int subtotal=0;
    private int madera=0;
    private int vacunas=0;
    private int tiritas=0;
    private int suministros=0;
    private int pveMadera=(int)(60*Globales.ECONOMIA);
    private int pveVacuna=(int)(950*Globales.ECONOMIA);
    private int pveTirita=(int)(180*Globales.ECONOMIA);
    private int pveSuministro=(int)(350*Globales.ECONOMIA);
    [SerializeField]
    private TextMeshProUGUI maderaText;
    [SerializeField]
    private TextMeshProUGUI vacunaText;
    [SerializeField]
    private TextMeshProUGUI tiritaText;
    [SerializeField]
    private TextMeshProUGUI suministroText;

    [SerializeField]
    private TextMeshProUGUI precioMadera;
    [SerializeField]
    private TextMeshProUGUI precioVacuna;
    [SerializeField]
    private TextMeshProUGUI precioTirita;
    [SerializeField]
    private TextMeshProUGUI precioSuministro;
    [SerializeField]
    private TextMeshProUGUI textSubtotal;
    private void Awake(){
        updatetexts();
        precioMadera.text=$"{pveMadera}$";
        precioVacuna.text=$"{pveVacuna}$";
        precioTirita.text=$"{pveTirita}$";
        precioSuministro.text=$"{pveSuministro}$";
    }
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
        maderaText.text=$"{madera}";
        vacunaText.text=$"{vacunas}";
        tiritaText.text=$"{tiritas}";
        suministroText.text=$"{suministros}";
        subtotal=madera*pveMadera+vacunas*pveVacuna+tiritas*pveTirita+suministros*pveSuministro;
        textSubtotal.text=$"{subtotal}";
    }
    public void OnCompra(){
        if(subtotal<=Globales.DINERO){
            Globales.DINERO-=subtotal;
            Globales.madera+=madera;
            Globales.vacunas+=vacunas;
            Globales.tiritas+=tiritas;
            Globales.suministros+=suministros;
            reset();
        }
    }
    public void OnVenta(){
        if(madera<=Globales.madera && vacunas<=Globales.vacunas && tiritas<=Globales.tiritas && suministros<=Globales.suministros){
            Globales.DINERO+=subtotal;
            Globales.madera-=madera;
            Globales.vacunas-=vacunas;
            Globales.tiritas-=tiritas;
            Globales.suministros-=suministros;
            reset();
        }
    }
    private void reset(){
        madera=0;
        vacunas=0;
        tiritas=0;
        suministros=0;
        updatetexts();
    }
}
