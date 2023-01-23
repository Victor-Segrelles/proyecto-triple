using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PrecioTir : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI countText;
    private void Awake(){
        countText.text=$"{120*Globales.ECONOMIA}$";
    }
}