using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Puerto : MonoBehaviour
{
    public GameObject blackScreen;
    public TextMeshProUGUI text1;
    public TextMeshProUGUI text2;
    public GameObject tanic;
    public TextAsset inkJSON;
    public TextAsset inkJSON2;
    public TextAsset inkJSON3;
    public TextAsset inkJSON4;
    public string escena;
    float fspeed = 0.5f;
    Color objectColor;
    float fadeAmount = 1;
    float fadeText = 0;
    bool startFading;
    bool textchange;
    int continuacion;

    // Start is called before the first frame update
    void Start()
    {
        continuacion = 0;
        tanic.SetActive(false);
        textchange = false;
        startFading = true;
        blackScreen.SetActive(true);
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
                if (continuacion == 2)
                    continuacion++;

            }
        }
        else if (!DialogueManager.GetInstance().DialoguePlaying())
        {
            fadeAmount += fspeed * Time.deltaTime;
            objectColor = new Color(0, 0, 0, fadeAmount);
            blackScreen.GetComponent<Image>().color = objectColor;
            if (fadeAmount > 1)
            {
                if(continuacion == 0)
                {
                    tanic.SetActive(true);
                    inkJSON = inkJSON2;
                    text1.text = "Jeringuito, con su evidente falta de conocimiento sobre cómo funciona un barco, empieza a tocar botones sin saber qué está haciendo.";
                    text2.text = "Antes de salir del puerto se escucha un ruido y Jeringuito sale del barco para ver qué ha ocurrido.";
                    FadeText();
                }
                else if(continuacion == 1)
                {
                    DialogueManager.GetInstance().EnterDialogueMode(inkJSON3);
                    continuacion++;
                    text1.text = "";
                    text2.text = "";
                }
                else if(continuacion == 2)
                {
                    startFading = true;
                    inkJSON = inkJSON4;
                }
                else if(continuacion == 3)
                {
                    SceneManager.LoadScene("MinigameDriving");
                }

            }

        }
    }

    void FadeText()
    {
        fadeText += fspeed * Time.deltaTime;

        objectColor = new Color(255f, 255f, 255f, fadeText);
        if (!textchange)
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
                fadeText = 0;
                textchange = false;
                startFading = true;
                continuacion++;
            }

        }
    }

}
