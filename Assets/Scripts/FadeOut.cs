using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FadeOut : MonoBehaviour
{
    public GameObject blackScreen;
    public TextMeshProUGUI text1;
    public TextMeshProUGUI text2;
    float fspeed = 0.5f;
    Color objectColor;
    float fadeAmount = 1;
    float fadeText = 0;
    bool startFading;
    bool textchange;
    bool finished;

    // Start is called before the first frame update
    void Start()
    {
        startFading = false;
        blackScreen.SetActive(true);
        textchange = false;
        finished = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (startFading)
        {
            fadeAmount -= fspeed * Time.deltaTime;
            Debug.Log(fadeAmount);

            objectColor = new Color(0, 0, 0, fadeAmount);
            blackScreen.GetComponent<Image>().color = objectColor;
            objectColor = new Color(255f, 255f, 255f, fadeAmount);
            text1.color = objectColor;
            text2.color = objectColor;
            if (fadeAmount < 0)
            {
                startFading = false;
            }
        }
        else
        {
            if(!finished)
                FadeText();
        } 
            
    }

    void FadeText()
    {
        fadeText += fspeed * Time.deltaTime;
        Debug.Log(fadeText);

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
