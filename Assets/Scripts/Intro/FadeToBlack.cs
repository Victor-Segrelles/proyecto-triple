using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FadeToBlack : MonoBehaviour
{
    public GameObject blackScreen;
    int fspeed = 1;
    Color objectColor;
    float fadeAmount = 0;
    bool startFading;
    
    // Start is called before the first frame update
    void Start()
    {
        blackScreen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(startFading)
        {
            fadeAmount = objectColor.a + fspeed * Time.deltaTime;
            Debug.Log(fadeAmount);

            objectColor = new Color(0, 0, 0, fadeAmount);
            blackScreen.GetComponent<Image>().color = objectColor;

            if (fadeAmount > 1)
            {
                startFading = false;
                SceneManager.LoadScene("Clinica");
            }
                
        }

    }

    public void FadeBlack()
    {
        blackScreen.SetActive(true);
        startFading = true;
    }
}
