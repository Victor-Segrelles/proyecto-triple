using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class DrivingPlayerMovement : MonoBehaviour
{
    [SerializeField] private GameObject GameOverPanel;
    public float speed = 10;
    Vector3 lastClick;
    private Rigidbody2D rigidbody2d;
    public GameObject[] Lives;
    public int life;
    private string destino = DialogueManager.GetInstance().GetDestino();

    void Start()
    {
        GameOverPanel.SetActive(false);
        lastClick = Input.mousePosition;
        rigidbody2d = GetComponent<Rigidbody2D>();
    }
    void Update() {
        Debug.Log(destino);
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
            Destroy(collision.gameObject);
            Destroy(Lives[life-1]);
            life--;
            if (life <= 0)
            {
                GameOver();
            }
        }
        if (collision.gameObject.CompareTag("Final"))
        {
            SceneManager.LoadScene(destino); //Uso Level1 porque a�n no hay m�s escenas
        }
    } 

    void GameOver()
    {
        Time.timeScale = 0;
        GameOverPanel.SetActive(true);
    }


}
