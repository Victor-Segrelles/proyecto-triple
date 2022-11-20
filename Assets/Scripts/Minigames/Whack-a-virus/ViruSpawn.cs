using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ViruSpawn : MonoBehaviour
{
    public GameObject virusPrefab;
    public Transform[] spawnPoints;


    GameObject virus;
    Vector2 virusPos;


    // Start is called before the first frame update
    void Start()
    {
        Spawn();
    }

    // Update is called once per frame
    void Update()
    {
        VirusDestruction();
    }
    void Spawn()
    {
        virus = Instantiate(virusPrefab) as GameObject;
        virus.transform.position = spawnPoints[Random.Range(0,spawnPoints.Length)].transform.position;
        virusPos =  virus.transform.position;
    }
    void VirusDestruction()
    {
        //Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);
        //RaycastHit2D overVirus = Physics2D.Raycast(mousePos2D, Vector2.zero);



        if(Input.GetMouseButtonDown(0))  // && overVirus.collider != null)
            {
            Destroy(virus); //overVirus.transform.gameObject);
            Spawn();
        }
    }

   
}
