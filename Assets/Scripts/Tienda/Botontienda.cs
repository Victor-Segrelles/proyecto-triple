using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Botontienda : MonoBehaviour
{
    [SerializeField]
    private GameObject interfazi;
    public void OnClick(){
        interfazi.SetActive(false);
    }
}
