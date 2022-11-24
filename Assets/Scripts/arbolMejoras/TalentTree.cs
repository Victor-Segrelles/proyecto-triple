using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TalentTree : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private Talent[] talents;


    [SerializeField]
    private Talent[] unlockedByDefaultTalents;
    void Start()
    {
        ResetTalents();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void ResetTalents(){
        foreach (Talent talent in talents)
        {
            talent.Lock();
        }
        foreach(Talent talent in unlockedByDefaultTalents){
            talent.Unlock();
        }
    }
}
