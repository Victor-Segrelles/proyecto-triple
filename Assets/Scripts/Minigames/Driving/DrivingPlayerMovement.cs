using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class DrivingPlayerMovement : MonoBehaviour
{
    public float speed = 10;
    Vector3 lastClick;
    private Rigidbody2D rigidbody2d;
    public GameObject[] Lives;
    public int life;

    void Start()
    {
        lastClick = Input.mousePosition;
        rigidbody2d = GetComponent<Rigidbody2D>();
    }
    void Update() {
        if (Input.GetMouseButton(0)){
            lastClick = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Debug.Log(lastClick);
            if (lastClick.y > transform.position.y + 0.1)
            { 
                rigidbody2d.velocity = Vector2.up * speed;
            } 
            else if (lastClick.y < transform.position.y - 0.1)
            {
                rigidbody2d.velocity = Vector2.down * speed;
            }
            else
            {
                rigidbody2d.velocity = Vector2.up * 0;
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
  
            Destroy(Lives[life-1]);
            life--;
            if (life == 0)
            {
                SceneManager.LoadScene("GameOver");
            }
        }
        if (collision.gameObject.CompareTag("Final"))
        {
            SceneManager.LoadScene("Level1"); //Uso Level1 porque aún no hay más escenas
        }
    } 


}
