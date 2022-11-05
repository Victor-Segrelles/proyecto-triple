using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed =10f;
    Vector2 lastClick;
    bool moving;
    public Rigidbody2D rigidbody2d;
    void start(){
        rigidbody2d=GetComponent<Rigidbody2D>();
    }
    void Update() {
        if (Input.GetMouseButtonDown(0)){
            lastClick=Camera.main.ScreenToWorldPoint(Input.mousePosition);
            moving=true;
        }
    }
    void FixedUpdate(){
        if(moving && (Vector2)rigidbody2d.position !=lastClick){
            float step=speed*Time.deltaTime;
            //transform.position=Vector2.MoveTowards(transform.position, lastClick, step);
            ///Vector2 direction=(lastClick - transform.position).normalized;
            //rigidbody2d.AddForce(direction);
            rigidbody2d.MovePosition(Vector2.MoveTowards(rigidbody2d.position, lastClick, step));
        } else {
            moving=false;
        }
    }
}
