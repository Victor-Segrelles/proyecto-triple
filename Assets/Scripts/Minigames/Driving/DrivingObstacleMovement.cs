using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrivingObstacleMovement : MonoBehaviour
{
    //Este c�digo se encuentra en el prefab del objeto
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
