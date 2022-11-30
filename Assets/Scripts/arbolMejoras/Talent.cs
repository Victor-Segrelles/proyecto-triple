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

    [SerializeField]
    private int max;

    private int actual;
    [SerializeField]
    private bool unlocked;
    [SerializeField]
    private Talent child;



    [SerializeField]
    private Image arrowImage;
    [SerializeField]
    private Sprite arrowSpriteLock;
    [SerializeField]
    private Sprite arrowSpriteUnlock;



    public void Lock(){
        sprite.color=Color.gray;
        countText.color=Color.gray;
        if(arrowImage!=null){
            arrowImage.sprite=arrowSpriteLock;
        }
    }
    public void Unlock(){
        sprite.color=Color.white;
        countText.color=Color.white;
        if(arrowImage!=null){
            arrowImage.sprite=arrowSpriteUnlock;
        }
        unlocked=true;
    }
    private void Awake(){
        sprite=GetComponent<Image>();
        countText.text=$"{actual}/{max}";
    }
    public virtual bool Click(){
        if (actual<max && unlocked){
            actual++;
            countText.text=$"{actual}/{max}";
            if(actual==max && child!=null){
                child.Unlock();
            }
            return true;
        }
        return false;
    }
    public virtual float coste(){
        return 1.0f;
    }
}
