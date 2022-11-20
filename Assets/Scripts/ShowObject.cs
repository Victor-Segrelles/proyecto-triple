using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowObject : MonoBehaviour
{
    public GameObject TheObject;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D other)
    {
        ShowTheObject();
    }
    public void ShowTheObject()
    {
        if (TheObject.activeInHierarchy)
            TheObject.SetActive(false);
        else
            TheObject.SetActive(true);
        Debug.Log("Objeto creado");
        //if (Time.timeScale != 0)
        //    Time.timeScale = 0;
        //else
        //    Time.timeScale = 1;
    }
}
