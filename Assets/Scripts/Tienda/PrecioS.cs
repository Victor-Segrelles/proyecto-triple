using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PrecioS : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI countText;
    private void Awake(){
        countText.text=$"{340*Globales.ECONOMIA}$";
    }
}
