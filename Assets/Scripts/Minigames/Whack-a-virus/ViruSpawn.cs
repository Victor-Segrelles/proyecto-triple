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
    public GameObject[] spawnGrietas;
    public int[] nspawnPoints;
    private float initialTime = 0;
    public int random;

    GameObject virus;
    //Vector2 virusPos;

    // Start is called before the first frame update
    void Start()
    {
        Spawn();
        for (int i = 0; i < spawnPoints.Length; i++)
        {
            spawnGrietas[i].SetActive(false);
        }
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
            if (hit.collider!=null)
                if (hit.collider.gameObject.CompareTag("Virus"))
                {
                    GameObject.Destroy(hit.transform.gameObject);
                    spawnGrietas[random].SetActive(true);
                    spawnGrietas[random].transform.localScale = new Vector3(spawnGrietas[random].transform.localScale.x + 0.04f * nspawnPoints[random], spawnGrietas[random].transform.localScale.y + 0.04f * nspawnPoints[random], 1f);
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
        if(nspawnPoints[random] >= 5)
        {
            for (int i = 0; i < spawnPoints.Length; i++)
            {
                if (nspawnPoints[i] < 5)
                {
                    random = i;
                    break;
                } 
            }
        }
        nspawnPoints[random]++;
        virus.transform.position = spawnPoints[random].transform.position;
        //virusPos =  virus.transform.position;
    }




}
