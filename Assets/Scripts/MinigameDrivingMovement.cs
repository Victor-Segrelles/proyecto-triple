using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class MinigameDrivingMovement : MonoBehaviour
{
    public float speed = 10;
    Vector2 lastClick;
    private Rigidbody2D rigidbody2d;

    void Start()
    {
        lastClick = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        rigidbody2d = GetComponent<Rigidbody2D>();

    }
    void Update() {
        Vector2 position = rigidbody2d.position;
        Debug.Log(position);
        if (Input.GetMouseButton(0)){
            lastClick=Camera.main.WorldToScreenPoint(position);
            if (Input.mousePosition.y > Camera.main.pixelHeight / 2) 
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
}
