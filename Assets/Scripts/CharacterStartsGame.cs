using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStartsGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        string minijuego = ((Ink.Runtime.StringValue)DialogueManager.GetInstance().GetVariableState("minijuego")).value;
        Debug.Log(minijuego);
    }
}
