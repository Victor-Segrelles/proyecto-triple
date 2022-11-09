using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinigameDrivingGenerator : MonoBehaviour
{
    public float tiempoMax;
    private float tiempoInicial = 0;
    public GameObject Obstaculo;
    public float altura = 4;
    // Start is called before the first frame update
    void Start()
    {
        GameObject obstaculoNuevo = Instantiate(Obstaculo);
        obstaculoNuevo.transform.position = transform.position + new Vector3(0, 0, 0);
        Destroy(obstaculoNuevo, 8); //Cambiar los segundos si se modifica la velocidad
    }

    // Update is called once per frame
    void Update()
    {
        if (tiempoInicial > tiempoMax)
        {
            GameObject obstaculoNuevo = Instantiate(Obstaculo);
            obstaculoNuevo.transform.position = transform.position + new Vector3(0, Random.Range(-altura, altura), 0);
            Destroy(obstaculoNuevo, 8); //Cambiar los segundos si se modifica la velocidad
            tiempoInicial = 0;
        }
        else
        {
            tiempoInicial += Time.deltaTime;
        }
    }
}
