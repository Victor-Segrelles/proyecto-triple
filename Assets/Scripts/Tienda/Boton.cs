using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Botontronco : MonoBehaviour
{
    [SerializeField]
    private GameObject interfazTronco;
    public void OnClick(){
        interfazTronco.SetActive(true);
    }
}
