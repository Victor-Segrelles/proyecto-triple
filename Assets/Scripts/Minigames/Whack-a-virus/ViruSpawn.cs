using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class ViruSpawn : MonoBehaviour
{
    public GameObject virusPrefab;
    public Transform[] spawnPoints;
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private TextMeshProUGUI timeText;
    public int scoreNum;
    private float initialTime = 0;
    public int showTime;

    GameObject virus;
    //Vector2 virusPos;

    // Start is called before the first frame update
    void Start()
    {
        scoreNum = 0;
        Spawn();
        ShowScore();
        ShowTime();
    }

    // Update is called once per frame
    void Update()
    {
        if (initialTime >= 1)
        {
            initialTime = 0;
            showTime--;
            ShowTime();
            if (showTime == 0)
                SceneManager.LoadScene("GameOver"); //Game Over como ejemplo, se cambiará a la escena correspondiente
        }
        else
        {
            initialTime += Time.deltaTime;  
        }

        if (Input.GetMouseButtonDown(0))
        {
            //Transforma las unidades de las coordenadas del ratón
            Vector3 worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            // Crea un rayo en la posicion del ratón
            RaycastHit2D hit = Physics2D.Raycast(worldPosition, Vector2.zero);
            
            // Si el rayo detecta algo
            if (hit.collider != null)  
            {
                if (hit.collider.gameObject.CompareTag("Virus"))
                {
                    GameObject.Destroy(hit.transform.gameObject);
                    Spawn();
                    scoreNum++;
                }
                else
                {
                    scoreNum--;
                }
                ShowScore();
            }
        }
    }

            
    public void Spawn()
    {
        virus = Instantiate(virusPrefab) as GameObject;
        virus.transform.position = spawnPoints[Random.Range(0,spawnPoints.Length)].transform.position;
        //virusPos =  virus.transform.position;
    }

    public void ShowScore()
    {
        scoreText.text = "Puntos: " + scoreNum;
    }

    public void ShowTime()
    {
        timeText.text = "Tiempo: " + showTime;
    }



}
