using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    public float speed =10f;
    Vector2 lastClick;
    bool moving;
    public Rigidbody2D rigidbody2d;
    //actualizar capa dinamicamente
    public SpriteRenderer sprite;

    //Para controlar las animaciones 
    public Animator animator;

    void start(){
        rigidbody2d=GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        sprite.sortingOrder=0;
    }
    void Update() {
        if (Input.GetMouseButtonDown(0)){
            lastClick=Camera.main.ScreenToWorldPoint(Input.mousePosition);
            moving=true;
        }
        animator.SetBool("walk", moving);
        UpdateDirection();
    }
    void FixedUpdate(){
        if(moving && (Vector2)rigidbody2d.position !=lastClick){
            float step=speed*Time.deltaTime;
            rigidbody2d.MovePosition(Vector2.MoveTowards(rigidbody2d.position, lastClick, step));
            actualizarCapa();
        } else {
            moving=false;
        }
        //animator.SetBool("walk", moving);
    }
    void actualizarCapa(){
        if(rigidbody2d.position.y<-3){
            sprite.sortingOrder=1;
        } else if(rigidbody2d.position.y>=-3 && rigidbody2d.position.y<-2){
            sprite.sortingOrder=0;
        } else {
            sprite.sortingOrder=-1;
        }
        //Debug.Log(sprite.sortingOrder); <>
    }


    void UpdateDirection()
    {
        if (lastClick.x < rigidbody2d.position.x)
        {
            animator.SetInteger("direction", -1);
        }
        else if (lastClick.x > rigidbody2d.position.x)
        {
            animator.SetInteger("direction", 1);
        }

    }
    
}
