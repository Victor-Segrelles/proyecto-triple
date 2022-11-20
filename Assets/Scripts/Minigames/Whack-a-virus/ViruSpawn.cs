using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ViruSpawn : MonoBehaviour
{
    public GameObject virusPrefab;
    public Transform[] spawnPoints;


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
        if (Input.GetMouseButtonDown(0))
        {
            //Transforma las unidades de las coordenadas del ratón
            Vector3 worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            // Crea un rayo en la posicion del ratón
            RaycastHit2D hit = Physics2D.Raycast(worldPosition, Vector2.zero);
            
            // Si el rayo detecta algo
            if (hit.collider != null)
            {
                GameObject.Destroy(hit.transform.gameObject);
                Spawn();
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
