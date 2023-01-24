using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class VirusPointsTime : MonoBehaviour
{
    [SerializeField] public TextMeshProUGUI scoreText;
    [SerializeField] public TextMeshProUGUI timeText;
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
