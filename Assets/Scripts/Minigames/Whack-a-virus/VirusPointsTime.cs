using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class VirusPointsTime : MonoBehaviour
{
    [SerializeField] public TextMeshProUGUI scoreText;
    [SerializeField] public TextMeshProUGUI timeText;
    [SerializeField] public GameObject grietas1;
    [SerializeField] public GameObject grietas2;
    [SerializeField] public GameObject grietas3;
    [SerializeField] private GameObject GameOverPanel;
    public int scoreNum;
    public int showTime;
    private static VirusPointsTime instance;
    // Start is called before the first frame update

    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        GameOverPanel.SetActive(false);
        GetInstance().ShowScore();
        timeText.text = "Tiempo: " + showTime;
        grietas1.SetActive(false);
        grietas2.SetActive(false);
        grietas3.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (showTime == 0)
            GameOver();
        if(scoreNum >= 30)
            SceneManager.LoadScene("Hielo"); //Game Over como ejemplo, se cambiará a la escena correspondiente
    }

    public void ShowScore()
    {
        scoreText.text = "Puntos: " + scoreNum;
        if (scoreNum == 10)
            grietas1.SetActive(true);
        if (scoreNum == 20)
        {
            grietas1.SetActive(false);
            grietas2.SetActive(true);
        }
        if(scoreNum == 29)
        {
            grietas2.SetActive(false);
            grietas3.SetActive(true);
        }

    }

    public void ShowTime()
    {
        showTime--;
        timeText.text = "Tiempo: " + showTime;
    }

    public void ChangeScore(bool points)
    {
        if (points)
            scoreNum++;
        else
            scoreNum--;
        
    }

    public static VirusPointsTime GetInstance()
    {
        return instance;
    }

    void GameOver()
    {
        Time.timeScale = 0;
        GameOverPanel.SetActive(true);
    }
}
