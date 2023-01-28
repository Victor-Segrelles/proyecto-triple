using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Tienda : MonoBehaviour
{
    public GameObject blackScreen;
    public TextAsset inkJSON;
    float fspeed = 0.5f;
    Color objectColor;
    float fadeAmount = 1;
    bool startFading;
    // Start is called before the first frame update
    void Start()
    {
        startFading = true;
        blackScreen.SetActive(true);
        Globales.tiendaCinematica=false;
    }

    // Update is called once per frame
    void Update()
    {
        if (startFading)
        {
            fadeAmount -= fspeed * Time.deltaTime;

            objectColor = new Color(0, 0, 0, fadeAmount);
            blackScreen.GetComponent<Image>().color = objectColor;
            if (fadeAmount < 0)
            {
                startFading = false;
                DialogueManager.GetInstance().EnterDialogueMode(inkJSON);
            }
        }
        else if (!DialogueManager.GetInstance().DialoguePlaying())
        {
            fadeAmount += fspeed * Time.deltaTime;

            objectColor = new Color(0, 0, 0, fadeAmount);
            blackScreen.GetComponent<Image>().color = objectColor;
            if (fadeAmount > 1)
            {
                if(Globales.clinicaDonado=="true"){
                    Globales.DINERO-=2500.0f;
                } else {
                    Globales.DINERO-=15000.0f;
                }
                Globales.madera+=3;
                Globales.vacunas+=2;
                Globales.tiritas+=4;
                Globales.suministros+=4;
                SceneManager.LoadScene("Ciudad");
            }

        }
    }
}
