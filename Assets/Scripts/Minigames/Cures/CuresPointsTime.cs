using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class CuresPointsTime : MonoBehaviour
{
    [SerializeField] public TextMeshProUGUI scoreText;
    [SerializeField] public TextMeshProUGUI timeText;
    public int scoreNum;
    public int showTime;
    private float initialTime = 0;
    private static CuresPointsTime instance;
    // Start is called before the first frame update
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        scoreText.text = "Puntos: " + scoreNum;
        timeText.text = "Tiempo: " + showTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (initialTime >= 1)
        {
            initialTime = 0;
            GetInstance().ShowTime();
        }
        else
        {
            initialTime += Time.deltaTime;
        }

        if (showTime == 0)
            SceneManager.LoadScene("Selva"); //Game Over como ejemplo, se cambiar� a la escena correspondiente
    }

    public void ShowScore()
    {
        scoreNum ++;
        scoreText.text = "Puntos: " + scoreNum;
    }

    public void ShowTime()
    {
        showTime--;
        timeText.text = "Tiempo: " + showTime;
    }

    public static CuresPointsTime GetInstance()
    {
        return instance;
    }
}
