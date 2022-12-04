using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class CuresMovement : MonoBehaviour
{
    //Este código se encuentra en el prefab del objeto
    private float velocidad = 2;
    Vector3 mousePos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.CompareTag("Arriba"))
            transform.position += Time.deltaTime * velocidad * Vector3.up;
        else if (gameObject.CompareTag("Abajo"))
            transform.position += Time.deltaTime * velocidad * Vector3.down;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (gameObject.name == collision.gameObject.name)
        {
            Destroy(gameObject);

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
        gameObject.tag = "Untagged";
    }
}
