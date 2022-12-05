using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoMeDestruyas : MonoBehaviour
{
    // para algo servira
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }
}
