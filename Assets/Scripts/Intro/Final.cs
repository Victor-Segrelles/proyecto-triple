using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Final : MonoBehaviour
{
    public TextMeshProUGUI text1;
    public TextMeshProUGUI text2;
    float fspeed = 0.2f;
    Color objectColor;
    float fadeText = 0;
    bool startFading;
    bool textchange;
    int continuacion;

    // Start is called before the first frame update
    void Start()
    {
        startFading = false;
        textchange = false;
        continuacion = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (startFading)
        {
            if(continuacion == 3)
            {
                SceneManager.LoadScene("Hielo");
            }
            fadeText -= fspeed * Time.deltaTime;
            objectColor = new Color(255f, 255f, 255f, fadeText);
            text1.color = objectColor;
            text2.color = objectColor;
            if (fadeText < 0)
            {
                startFading = false;
            }
        }
        else
        {
            FadeText();
            if (continuacion == 1)
            {
                text1.text = "Los habitantes de Obuget se enfadaron con el rey Codicio. Este acabó dándose cuenta de que había hecho muchas cosas mal, se disculpó y trató de ser mejor persona.";
                text2.text = "Al final, nuestro protagonista consiguió lograr ayudar a mucha gente gracias a su gran corazón.";
            }
            else if (continuacion == 2)
            {
                text1.text = "Ahora te toca a tí.";
                text2.text = "¡Gracias por jugar!";
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
