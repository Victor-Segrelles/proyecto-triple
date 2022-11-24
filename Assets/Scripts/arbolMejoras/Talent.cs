using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Talent : MonoBehaviour
{
    private Image sprite;
    [SerializeField]
    private TextMeshProUGUI countText;
    public void Lock(){
        sprite.color=Color.gray;
        countText.color=Color.gray;
    }
    public void Unlock(){
        sprite.color=Color.white;
        countText.color=Color.white;
    }
    private void Awake(){
        sprite=GetComponent<Image>();
    }
}
