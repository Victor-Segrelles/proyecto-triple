using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class MinigameConductionMovement : MonoBehaviour
{
    public float speed = 5f;
    Vector2 lastClick;   
    bool pressed = false;
    public void Update() {
        Vector2 position = transform.position;
        if (Input.GetMouseButton(0)){
            lastClick=Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (lastClick.y > 0 && position.y < 5){ //Cambiar este numero
                position.y = position.y + speed * Time.deltaTime;
            } 
            else if (lastClick.y <= 0 && position.y > -5) {
                position.y = position.y - speed * Time.deltaTime;
            }
            transform.position=position;
        }
    }
}
