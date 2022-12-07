using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrivingObstacleMovement : MonoBehaviour
{
    //Este código se encuentra en el prefab del objeto
    public float velocidad;
    public SpriteRenderer spriteRenderer;
    public Sprite sprite1;
    public Sprite sprite2;
    private int n;
    // Start is called before the first frame update
    void Start()
    {
        n = Random.Range(0, 2);
        if (n == 0)
            spriteRenderer.sprite = sprite1;
        if (n==1)
            spriteRenderer.sprite = sprite2;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Time.deltaTime * velocidad * Vector3.right;
    }
}
