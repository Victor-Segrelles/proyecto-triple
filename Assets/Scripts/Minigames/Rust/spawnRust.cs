using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnRust : MonoBehaviour
{
    public Transform[] character;
    public GameObject rustPrefab;
    public GameObject markPrefab;
    public Transform barra;
    int i;
    
    //Collider2D collider;
    Vector3 rustPosition;
    Vector3 markPosition;

    // Start is called before the first frame update
    void Start()
    {
        // collider = GetComponent<Collider2D>();
        i = 0;
        rustPosition = new Vector3(Random.Range(-7f, 7f), Random.Range(-4f, 4f), 0f);
        generateRust(Random.Range(2, 5));
    }

    // Update is called once per frame
    void Update()
    {
        //if (isInsideBounds(rustPosition, character[i]))
        // {
        // Instantiate(rustPrefab, rustPosition, Quaternion.identity);

        //}
        
    
        
    }

    //controlar que el oxido aparezca en sitios aleatorios DENTRO del personaje
    void generateRust(float cantidad)
    {
        int i = 0;
        while (i < cantidad)
        {
            RaycastHit2D rustHit = Physics2D.Raycast(rustPosition, Vector2.zero);

            // Si el rayo detecta algo 
            if (rustHit.collider != null)
            {

                markPosition = new Vector3(barra.transform.position.x, rustPosition.y, 0f);

                RaycastHit2D markHit = Physics2D.Raycast(markPosition, Vector2.zero);
                if (markHit.collider == null)
                {
                    Instantiate(rustPrefab, rustPosition, Quaternion.identity);
                    Instantiate(markPrefab, markPosition, Quaternion.identity);
                    i++;
                }



            }

            rustPosition = new Vector3(Random.Range(-7f, 7f), Random.Range(-4f, 4f), 0f);
        }
    }



    //bool isInsideBounds(Vector3 objectPosition, Transform objectBounds)
    //{
    //return ((objectPosition - objectBounds.transform.position).magnitude < 2);
    //}
}


