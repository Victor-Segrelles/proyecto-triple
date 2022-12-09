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
    public int random;

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
            if (hit.collider.gameObject.CompareTag("Virus"))
                if (hit.collider.gameObject.CompareTag("Virus"))
                {
                    GameObject.Destroy(hit.transform.gameObject);
                    Spawn();
                    VirusPointsTime.GetInstance().ChangeScore(true);
                }
                VirusPointsTime.GetInstance().ShowScore();
        }
    }

            
    public void Spawn()
    {
        virus = Instantiate(virusPrefab) as GameObject;
        random = Random.Range(0, spawnPoints.Length);
        virus.transform.position = spawnPoints[random].transform.position;
        virus.transform.localScale = spawnPoints[random].transform.localScale/2;
        //virusPos =  virus.transform.position;
    }




}
