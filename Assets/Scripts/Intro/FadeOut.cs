using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class FadeOut : MonoBehaviour
{
    //ESTE ES EL C�DIGO DE LA INTRO, SE QUEDA COMO FADE OUT, ME DA IGUAL
    public GameObject blackScreen;
    public TextMeshProUGUI text1;
    public TextMeshProUGUI text2;
    public TextAsset inkJSON;
    public TextAsset inkJSONcont; //Esto est� fatal pero no hay tiempo para hacer c�digo bonito
    float fspeed = 0.5f;
    Color objectColor;
    float fadeAmount = 1;
    float fadeText = 0;
    bool startFading;
    bool textchange;
    bool finished;
    int continuacion;

    // Start is called before the first frame update
    void Start()
    {
        startFading = false;
        blackScreen.SetActive(true);
        textchange = false;
        finished = false;
        continuacion = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (startFading)
        {
            if (continuacion == 2)
            {
                //get set de globales
                Globales.clinicaDonado=DialogueManager.GetInstance().GetUniversal("clinicaDonado");
                if(Globales.clinicaDonado=="true"){
                    Globales.DINERO-=10000.0f;
                }
                SceneManager.LoadScene("Trono");
            }
            fadeAmount -= fspeed * Time.deltaTime;

            objectColor = new Color(0, 0, 0, fadeAmount);
            blackScreen.GetComponent<Image>().color = objectColor;
            objectColor = new Color(255f, 255f, 255f, fadeAmount);
            text1.color = objectColor;
            text2.color = objectColor;
            if (fadeAmount < 0)
            {
                startFading = false;
                DialogueManager.GetInstance().EnterDialogueMode(inkJSON);
 
            }
        }
        else
        {
            if(!finished)
                FadeText();
            else if (!DialogueManager.GetInstance().DialoguePlaying())
            {
                fadeAmount += fspeed * Time.deltaTime;

                objectColor = new Color(0, 0, 0, fadeAmount);
                blackScreen.GetComponent<Image>().color = objectColor;
                if (fadeAmount > 1)
                {
                    startFading = false;
                    textchange = false;
                    finished = false;
                    if (continuacion == 0)
                    {
                        inkJSON = inkJSONcont;
                        text1.text = "...con un rey que no se preocupa por sus ciudadanos";
                        text2.text = "y pone los precios de los servicios primarios por las nubes.";
                        continuacion = 1;
                    }
                    else if (continuacion == 1)
                    {
                        text1.text = "Y así, Jeringuito se dirigió a la sala del trono para su audiencia con el rey.";
                        text2.text = "";
                        continuacion = 2;
                    }

                }

            }
        } 
            
    }

    void FadeText()
    {
        fadeText += fspeed * Time.deltaTime;

        objectColor = new Color(255f, 255f, 255f, fadeText);
        if(!textchange)
            text1.color = objectColor;
        else
            text2.color = objectColor;
        if (fadeText > 1)
        {
            fadeText = 0;
            if (!textchange)
                textchange = true;
            else
            {
                startFading = true;
                finished = true;
            }
                
        }
    }

   
}
