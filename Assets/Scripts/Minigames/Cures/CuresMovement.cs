using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class CuresMovement : MonoBehaviour
{
    //Este código se encuentra en el prefab del objeto
    private float velocidad = 2;
    private bool inTable;
    private bool dragged;
    Vector3 mousePos;
    public SpriteRenderer spriteRenderer;
    public Sprite spriteIzq;
    public Sprite spriteDer;
    // Start is called before the first frame update
    void Start()
    {
        inTable = false;
        dragged = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.CompareTag("Arriba"))
        {
            transform.position += Time.deltaTime * velocidad * Vector3.up;
            spriteRenderer.sprite = spriteDer;
        }
            
        else if (gameObject.CompareTag("Abajo"))
        {
            transform.position += Time.deltaTime * velocidad * Vector3.down;
            spriteRenderer.sprite = spriteIzq;
        }
            
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Collider"))
            Destroy(gameObject);
        else
            inTable = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        inTable = false;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (gameObject.name == collision.gameObject.name && gameObject.tag != collision.gameObject.tag && inTable && dragged)
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
            CuresPointsTime.GetInstance().ShowScore();
        }
    }

    private void OnMouseDown()
    {
        mousePos = gameObject.transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    private void OnMouseDrag()
    {
        transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition) + mousePos;
        if(spriteRenderer.sprite == spriteDer)
            gameObject.tag = "Derecha";
        if(spriteRenderer.sprite == spriteIzq)
            gameObject.tag = "Izquierda";
        dragged = true;
    }

    private void OnMouseUp()
    {
        dragged = false;
    }

}
