using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Trono : MonoBehaviour
{
    public GameObject blackScreen;
    public TextAsset inkJSON;
    public TextAsset inkJSON2;
    public TextMeshProUGUI text1;
    public float speed = 8f;
    float fspeed = 0.5f;
    Color objectColor;
    float fadeAmount = 1;
    float fadeText = 0;
    bool startFading;
    bool finished;
    bool continuar;
    public Rigidbody2D rigidbody2d;
    Vector2 target;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        continuar = false;
        finished = false;
        startFading = true;
        blackScreen.SetActive(true);
        target = new Vector2(-3f, -3f);
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
            if (fadeAmount < 0)
            {
                startFading = false;
                DialogueManager.GetInstance().EnterDialogueMode(inkJSON);
            }
        }
        else
        {
            if (!DialogueManager.GetInstance().DialoguePlaying())
            {
                float step = speed * Time.deltaTime;
                animator.SetBool("walk", true);
                animator.SetInteger("direction", 1);
                rigidbody2d.MovePosition(Vector2.MoveTowards(rigidbody2d.position, target, step));
                if (continuar)
                    finished = true;
                if (rigidbody2d.position == target && !finished)
                {
                    rigidbody2d.position = target;
                    animator.SetBool("walk", false);
                    animator.enabled = false;
                    DialogueManager.GetInstance().EnterDialogueMode(inkJSON2);
                    continuar = true;
                }
            }
        }

        if (finished)
        {
            text1.text = "Jeringuito, apenado, abandona el castillo y se dirige a la plaza de la ciudad.";
            fadeAmount += fspeed * Time.deltaTime;

            objectColor = new Color(0, 0, 0, fadeAmount);
            blackScreen.GetComponent<Image>().color = objectColor;
            if (fadeAmount > 1)
            {
                fadeText += fspeed * Time.deltaTime;
                objectColor = new Color(255, 255, 255, fadeText);
                text1.color = objectColor;
            }
            if (fadeText > 1)
            {
                SceneManager.LoadScene("Ciudad");
            }
        }

    }
}
