using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PuertaTienda : MonoBehaviour
{
    [Header("la puerta")]
    [SerializeField]
    private GameObject door;

    private void Awake()
    {
        door.SetActive(false);
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0)){
            Vector3 worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(worldPosition, Vector2.zero);
            if(hit.collider != null && hit.collider.gameObject == door)
            {
                if(Globales.tiendaCinematica){
                    SceneManager.LoadScene("TiendaCinematica");
                } else {
                    SceneManager.LoadScene("Tienda");
                }
            }
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            door.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            door.SetActive(false);
        }
    }
}
