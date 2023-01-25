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
    // Start is called before the first frame update
    void Start()
    {
        startFading = false;
        blackScreen.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        FadeText();
        if (startFading)
        {
            fadeAmount -= fspeed * Time.deltaTime;
            Debug.Log(fadeAmount);

            objectColor = new Color(0, 0, 0, fadeAmount);
            blackScreen.GetComponent<Image>().color = objectColor;
            if (fadeAmount < 0)
            {
                startFading = false;
            }
        }
    }

    void FadeText()
    {
        fadeText += fspeed * Time.deltaTime;
        Debug.Log(fadeText);

        objectColor = new Color(255f, 255f, 255f, fadeText);
        text1.color = objectColor;
    }
}
