using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Botontienda : MonoBehaviour
{
    [SerializeField]
    private GameObject interfazi;
    public void OnClick(){
        SceneManager.LoadScene("Ciudad");
        interfazi.SetActive(false);
    }
}
