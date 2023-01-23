using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PrecioT : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI countText;
    private void Awake(){
        countText.text=$"{500*Globales.ECONOMIA}$";
    }
}
