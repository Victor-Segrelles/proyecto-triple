using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    public float speed =10f;
    Vector2 lastClick;
    bool moving;
    //float toleranciaMovimiento=0.1f; (obsoleto)
    public Rigidbody2D rigidbody2d;
    Vector2 lastPos;
    //actualizar capa dinamicamente
    public SpriteRenderer sprite;

    //Para controlar las animaciones 
    public Animator animator;

    void Start(){
        rigidbody2d=GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        sprite.sortingOrder=0;
        lastPos = rigidbody2d.position;
        rigidbody2d.position=Globales.lastPosition;
    }
    void Update() {
        Debug.Log(Globales.paraselva);
        if (Input.GetMouseButton(0)){
            lastClick=Camera.main.ScreenToWorldPoint(Input.mousePosition);
            moving=true;
        } else {
            moving=false;
        }
    }
    void FixedUpdate(){

        if (DialogueManager.GetInstance().dialogueIsPlaying)
        {
            return;
        }

        if (Input.GetMouseButton(0)){
            float step=speed*Time.fixedDeltaTime;
            rigidbody2d.MovePosition(Vector2.MoveTowards(rigidbody2d.position, lastClick, step));
            actualizarCapa();
        }
        animator.SetBool("walk", moving);
        UpdateDirection();

        //rastreo de velocidad (obsoleto, simplificado)
        /*
        Vector2 trackVelocity = (rigidbody2d.position - lastPos) * (1/Time.fixedDeltaTime);
        lastPos = rigidbody2d.position;
        if((abs)trackVelocity.y<toleranciaMovimiento && (abs)trackVelocity.x<toleranciaMovimiento){
            moving=false;
        } else {
            moving=true;
        }
        Debug.Log(trackVelocity);
        Debug.Log(lastClick);
        */
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
