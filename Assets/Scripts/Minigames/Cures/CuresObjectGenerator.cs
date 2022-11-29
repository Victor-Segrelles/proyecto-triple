using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuresObjectGenerator : MonoBehaviour
{

    public GameObject[] Cures;
    private int n;
    public float maxTime = 1; //Ir cambiando para la frecuencia de aparición
    private float initialTime = 0;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (initialTime > maxTime)
        {
            n = Random.Range(0, Cures.Length);
            GameObject curaNueva = Instantiate(Cures[n]);
            curaNueva.transform.position = transform.position + new Vector3(0, 0, 0);
            curaNueva.tag = "Abajo";
            Destroy(curaNueva, 7); //Esto hay que cambiarlo ya que si lo coges no deberia desaparecer

            n = Random.Range(0, Cures.Length);
            GameObject curaNueva2 = Instantiate(Cures[n]);
            curaNueva2.transform.position = transform.position + new Vector3(10, -12, 0);
            curaNueva2.tag = "Arriba";
            Destroy(curaNueva, 7); //Esto hay que cambiarlo ya que si lo coges no deberia desaparecer

            initialTime = 0;
        }
        else
        {
            initialTime += Time.deltaTime;
        }
    }
}
