using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PrecioV : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI countText;
    private void Awake(){
        countText.text=$"{950*Globales.ECONOMIA}$";
    }
}
