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
    private float initialTime = 0;

    GameObject virus;
    //Vector2 virusPos;

    // Start is called before the first frame update
    void Start()
    {
        Spawn();
    }

    // Update is called once per frame
    void Update()
    {
        if (initialTime >= 1)
        {
            initialTime = 0;
            VirusPointsTime.GetInstance().ShowTime();
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
                    VirusPointsTime.GetInstance().ChangeScore(true);
                }
                else
                {
                    VirusPointsTime.GetInstance().ChangeScore(false);
                }
                VirusPointsTime.GetInstance().ShowScore();
            }
        }
    }

            
    public void Spawn()
    {
        virus = Instantiate(virusPrefab) as GameObject;
        virus.transform.position = spawnPoints[Random.Range(0,spawnPoints.Length)].transform.position;
        //virusPos =  virus.transform.position;
    }




}
