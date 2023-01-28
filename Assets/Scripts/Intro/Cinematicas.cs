using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Cinematicas : MonoBehaviour
{
    public GameObject blackScreen;
    public TextMeshProUGUI text1;
    public TextMeshProUGUI text2;
    public TextAsset inkJSON;
    public string escena;
    public string aCambiar;
    float fspeed = 0.5f;
    Color objectColor;
    float fadeAmount = 1;
    bool startFading;

    // Start is called before the first frame update
    void Start()
    {
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

            }
        }
        else if (!DialogueManager.GetInstance().DialoguePlaying())
        {
            fadeAmount += fspeed * Time.deltaTime;

            objectColor = new Color(0, 0, 0, fadeAmount);
            blackScreen.GetComponent<Image>().color = objectColor;
            if (fadeAmount > 1)
            {
                switch(aCambiar) 
                {
                case "partir":
                    Globales.partir="false";
                    break;
                case "paraselva":
                     Globales.paraselva = "false";
                     break;
                default:
                    // code block
                    break;
                }
                SceneManager.LoadScene(escena);
            }

        }
    }

}


