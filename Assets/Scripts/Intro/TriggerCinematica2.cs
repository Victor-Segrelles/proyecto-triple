using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerCinematica2 : MonoBehaviour
{
    public GameObject trigger;
    public string cinematica;
    public Vector3 posicion;
    // Start is called before the first frame update
    void Start()
    {
        if (Globales.diccionario.ContainsKey(cinematica))
        {
            trigger.SetActive(false);
        }
        else
        {
            trigger.SetActive(true);
        }

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Globales.diccionario.Add(cinematica, true);
        Globales.lastPosition = posicion;
        SceneManager.LoadScene(cinematica);
    }
}
