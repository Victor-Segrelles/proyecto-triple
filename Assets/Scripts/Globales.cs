using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Globales : MonoBehaviour
{
    public static int PRESTIGE=0;
    public static float DINERO=16000;
    public static float DINERO_RECAMBIO=4000;



    //multiplicadores
    //reduce costes en tienda materiales
    public static float ECONOMIA=1;
    //mejora resultados (dando mas prestigio)
    public static float REPUTACION=1;
    //mejora resultados (en general)
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

    //desbloqueos de zonas viaje rapido

    public static bool Medieval=false;
    public static bool Hielo=false;
    public static bool Selva=false;
    public static bool Desierto=false;

    //recursos
    public static int madera=10;
    public static int suministros=10;
    public static int vacunas=10;
    public static int tiritas=10;

    //ink
    public static string partir="true";
    public static string clinicaDonado="true";
    public static string paraselva = "true";
    public static string paradesierto = "true";
    public static string parahielo = "true";
    public static string cinematicavista = "true";
    public static string parafinal = "true";
    public static string checkRecursosSelva="true";
    //public static string partir="";
    //public static string partir="";

    //historio
    public static bool tiendaCinematica=true;
    public static bool clinicareparada=false;
    public static string estaTanic = "estaTanic";
    public static Dictionary<string, bool> diccionario = new Dictionary<string, bool>();
    //public static bool encuentroTanic=true;
    //public static bool encuentroHoye=true;
    public static Vector3 lastPosition = new Vector3(0,-3,0);

}
/* MANUAL DE USO 
Globales.VARIABLE= cosa */
