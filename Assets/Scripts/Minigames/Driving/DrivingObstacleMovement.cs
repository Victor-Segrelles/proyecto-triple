using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrivingObstacleMovement : MonoBehaviour
{
    public float velocidad;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Time.deltaTime * velocidad * Vector3.right;
    }
}
