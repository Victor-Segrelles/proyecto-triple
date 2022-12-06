using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class spawnRust : MonoBehaviour
{
    public GameObject[] character;
    public GameObject rustPrefab;
    public GameObject markPrefab;
    public Transform barra;
    public GameObject flecha;

    Vector3 rustPosition;
    Vector3 markPosition;

    int rustAmount;
    int charNum;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < character.Length; i++)
        {
            character[i].SetActive(false);
            character[i].gameObject.layer = LayerMask.NameToLayer("Ignore Raycast");
        }
        charNum = 0;
        setCharacter(charNum);
        
    }

    // Update is called once per frame<>
    void Update()
    {
        
        if (rustAmount <= 0)
        {
            character[charNum].SetActive(false);
            
            
            charNum++;
            
            if (charNum < character.Length)
            {
                //character[charNum].SetActive(true);
                setCharacter(charNum);
            }
            else 
            {
                SceneManager.LoadScene("GameOver"); //Game Over como ejemplo, se cambiará a la escena correspondiente
            }

        }
        else 
        {
            if (Input.GetMouseButtonDown(0))
            {
                destroyIfHit();
            }
        }
       
            


    }

    //controlar que el oxido aparezca en sitios aleatorios DENTRO del personaje
    void generateRust(int cantidad)
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

                //miro si ya había una marca en la barra para evitar que se superpongan, estén en la misma coord x o estén demasiado pegadas en la coord y
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

    //El personaje que aparezca se rellena con oxido y cambia de capa para que no se tenga en cuenta en los raycast
    void setCharacter(int i)
    {
        character[i].SetActive(true);
        character[i].gameObject.layer = LayerMask.NameToLayer("Default");
        rustPosition = new Vector3(Random.Range(-7f, 7f), Random.Range(-4f, 4f), 0f);

        rustAmount = Random.Range(3, 5);
        generateRust(rustAmount);
        character[i].gameObject.layer = LayerMask.NameToLayer("Ignore Raycast");
    }
    

    //Se lanza un rayo desde la posicion de la flecha. Si golpea una marca, le coloca la capa de Ignore Raycast y, si hay oxido, destruye ambos.
    //Si no hay oxido (que puede ocurrir dado que la colision de la marca es mas grande que la propia marca para evitar que spawneen pegadas) simplemente le devuelve a marca su capa original)
    void destroyIfHit()
    {
        Vector2 arrowPosition = flecha.transform.position;
        RaycastHit2D markHit = Physics2D.Raycast(arrowPosition, Vector2.right);
        //Debug.DrawRay(arrowPosition, transform.forward * 10, Color.green, 1.0f);

        if (markHit.collider != null)
        {
            if (markHit.collider.gameObject.CompareTag("Marca"))
            {
                markHit.collider.gameObject.layer = LayerMask.NameToLayer("Ignore Raycast");
                RaycastHit2D rustHit = Physics2D.Raycast(arrowPosition, Vector2.right);
                if (rustHit.collider != null)
                {
                    if (rustHit.collider.gameObject.CompareTag("Oxido"))
                    {
                        GameObject.Destroy(markHit.transform.gameObject);
                        GameObject.Destroy(rustHit.transform.gameObject);
                        rustAmount--;
                    }
                    
                }
                else
                {
                    markHit.collider.gameObject.layer = LayerMask.NameToLayer("Default");
                }
            }

        }
    }

    
}

/*Vector3 arrowPosition = new Vector3(flecha.transform.position.x, flecha.transform.position.y, 0f);
RaycastHit arrowHit = Physics.Raycast(arrowPosition, Vector3(1f, 0f, 0f));

RaycastHit2D[] results;

int numHits = Physics2D.GetRayIntersectionNonAlloc(arrowHit, results);

if (numHits == 2)
{
    for (int i = 0; i < numHits; i++)
    {
        Destroy(results[numHits]);
    }
}
*/