using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTriggerRecurso : MonoBehaviour
{
    [Header("Info")]
    [SerializeField] private GameObject info;

    [Header("Ink JSON")]
    [SerializeField] private TextAsset inkJSON;

    [SerializeField] private int vacunas=0;
    [SerializeField] private int madera=0;
    [SerializeField] private int tiritas=0;
    [SerializeField] private int suministros=0;


    private bool playerInRange;

    private void Awake()
    {
        playerInRange = false;
        info.SetActive(false);
    }

    private void Update()
    {
        if (playerInRange && !DialogueManager.GetInstance().dialogueIsPlaying)
        {
            info.SetActive(true);
            if (Input.GetMouseButtonDown(0))
            {
                Vector3 worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                RaycastHit2D hit = Physics2D.Raycast(worldPosition, Vector2.zero);
                if(hit.collider != null && hit.collider.gameObject.name == "Info")
                {
                    if(Globales.checkRecursosSelva=="false" && !Globales.clinicareparada){
                        Globales.vacunas+=vacunas;
                        Globales.madera+=madera;
                        Globales.tiritas+=tiritas;
                        Globales.suministros+=suministros;
                        Globales.clinicareparada=true;
                    }
                    EnterDialogue();
                }
            }
        }
        else
        {
            info.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            playerInRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            playerInRange = false;
        }
    }

    private void EnterDialogue()
    {
        DialogueManager.GetInstance().EnterDialogueMode(inkJSON);
    }

}
