using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FadeOut : MonoBehaviour
{
    //ESTE ES EL CÓDIGO DE LA INTRO, SE QUEDA COMO FADE OUT, ME DA IGUAL
    public GameObject blackScreen;
    public TextMeshProUGUI text1;
    public TextMeshProUGUI text2;
    public TextAsset inkJSON;
    public TextAsset inkJSONcont; //Esto está fatal pero no hay tiempo para hacer código bonito
    float fspeed = 0.5f;
    Color objectColor;
    float fadeAmount = 1;
    float fadeText = 0;
    bool startFading;
    bool textchange;
    bool finished;
    bool continuacion;

    // Start is called before the first frame update
    void Start()
    {
        startFading = false;
        blackScreen.SetActive(true);
        textchange = false;
        finished = false;
        continuacion = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (startFading)
        {
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
            else if (!DialogueManager.GetInstance().DialoguePlaying() && !continuacion)
            {
                fadeAmount += fspeed * Time.deltaTime;

                objectColor = new Color(0, 0, 0, fadeAmount);
                blackScreen.GetComponent<Image>().color = objectColor;
                if (fadeAmount > 1)
                {
                    startFading = false;
                    textchange = false;
                    finished = false;
                    continuacion = true;
                    text1.text = "...con un rey que no se preocupa por sus ciudadanos";
                    text2.text = "y pone los precios de los servicios primarios por las nubes";
                    inkJSON = inkJSONcont;
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
