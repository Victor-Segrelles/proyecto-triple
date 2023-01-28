using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Contadorrecursos : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI vacuna;
    [SerializeField]
    private TextMeshProUGUI tirita;
    [SerializeField]
    private TextMeshProUGUI madera;
    [SerializeField]
    private TextMeshProUGUI suministros;

    // Update is called once per frame
    void Update()
    {
        vacuna.text = Globales.vacunas.ToString();//esto es una abominacion pero bueno ya se upgradeara
        tirita.text = Globales.tiritas.ToString();//esto es una abominacion pero bueno ya se upgradeara
        madera.text = Globales.madera.ToString();//esto es una abominacion pero bueno ya se upgradeara
        suministros.text = Globales.suministros.ToString();//esto es una abominacion pero bueno ya se upgradeara
    }
}