using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class cerrarSecundario : MonoBehaviour
{
    [SerializeField]
    private GameObject interfazi;
    public void OnClick(){
        interfazi.SetActive(false);
    }
}