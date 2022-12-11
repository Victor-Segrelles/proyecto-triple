using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ContadorDinero : MonoBehaviour
{
    private TextMeshProUGUI mText;
    // Start is called before the first frame update
    void Start()
    {
        mText=gameObject.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        mText.text = Globales.DINERO.ToString();//esto es una abominacion pero bueno ya se upgradeara
    }
}
