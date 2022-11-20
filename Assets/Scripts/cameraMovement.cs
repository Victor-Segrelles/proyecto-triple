using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMovement : MonoBehaviour
{
    public int cameraSpeed;
    public GameObject player;
    void FixedUpdate(){
        //transform.position = new Vector3(player.transform.position.x, transform.position.y, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, new Vector3(player.transform.position.x, transform.position.y, transform.position.z), Time.deltaTime * cameraSpeed);
    }
}
