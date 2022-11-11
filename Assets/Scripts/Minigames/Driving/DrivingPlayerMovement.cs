using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class DrivingPlayerMovement : MonoBehaviour
{
    public float speed = 10;
    Vector2 lastClick;
    private Rigidbody2D rigidbody2d;

    void Start()
    {
        lastClick = Input.mousePosition;
        rigidbody2d = GetComponent<Rigidbody2D>();
    }
    void Update() {
        if (Input.GetMouseButton(0)){
            lastClick = Input.mousePosition;
            if (Input.mousePosition.y > Camera.main.pixelHeight/2)
            { 
                rigidbody2d.velocity = Vector2.up * speed;
            } 
            else {
                rigidbody2d.velocity = Vector2.down * speed;
            }
        }
        else
        {
            rigidbody2d.velocity = Vector2.up * 0;
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Obstaculo"))
        {
            Debug.Log("Fue hit");
        }
        if (collision.gameObject.CompareTag("Final"))
        {
            Debug.Log("Mu bien");
        }
    } 


}
