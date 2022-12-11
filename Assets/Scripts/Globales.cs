using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Globales : MonoBehaviour
{
    public static int PRESTIGE=0;
    public static float DINERO=30000;



    //multiplicadores
    //reduce costes en materiales
    public static float ECONOMIA=1;
    //mejora resultados (dando mas prestigio)
    public static float REPUTACION=1;
    //mejora resultados (en generan) y reduce gastos de materiales
    public static float EFICIENCIA=1;


    //arbol mejoras
    public static int Economia1=0;
    public static bool UnlockedEconomia1=true;
    public static int Eficiencia1=0;
    public static bool UnlockedEficiencia1=true;
    public static int Reputacion1=0;
    public static bool UnlockedReputacion1=true;
    //T2
    public static int Economia2=0;
    public static bool UnlockedEconomia2=false;
    public static int Eficiencia2=0;
    public static bool UnlockedEficiencia2=false;
    public static int Reputacion2=0;
    public static bool UnlockedReputacion2=false;
    //T3
    public static int Economia3=0;
    public static bool UnlockedEconomia3=false;
    public static int Eficiencia3=0;
    public static bool UnlockedEficiencia3=false;
    public static int Reputacion3=0;
    public static bool UnlockedReputacion3=false;
}
/* MANUAL DE USO 
Globales.VARIABLE= cosa */
