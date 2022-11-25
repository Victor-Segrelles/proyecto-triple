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
    //[SerializeField]
    //private TextMeshProUGUI countText;
    void Start()
    {
        ResetTalents();
    }

    public void TryMejora(Talent talent){
        if(Globales.DINERO>0 && talent.Click()){
            Globales.DINERO--;
            Debug.Log(Globales.DINERO);
        }
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
    private void UpdateMejorasText(){
        //countText.text=
    }
}
