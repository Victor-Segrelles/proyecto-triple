using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Ink.Runtime;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
//using Ink.UnityIntegration;



public class DialogueManager : MonoBehaviour
{
    [Header("Params")]
    private float typingSpeed = 0.01f; //Esto estaba en 0.04f si está diferente es que lo he cambiado para ver más rapido las cinemáticas

    [Header("Dialogue UI")]
    [SerializeField] private GameObject dialoguePanel;
    [SerializeField] private GameObject continueIcon;
    [SerializeField] private GameObject portraitImage;
    [SerializeField] private TextMeshProUGUI dialogueText;
    [SerializeField] private TextMeshProUGUI displayNameText;
    [SerializeField] private GameObject fondo;
    [SerializeField] private Sprite[] spriteArray;

    [Header("Choices UI")]
    [SerializeField] private GameObject[] choices;


    [Header("Load globals JSON")]
    [SerializeField] private TextAsset loadGlobalsJSON;

    private const string SPEAKER_TAG = "speaker";

    private const string PORTRAIT_TAG = "portrait";

    //private const string LAYOUT_TAG = "layout";


    private TextMeshProUGUI[] choicesText;

    private Story currentStory;
    public bool dialogueIsPlaying {get; private set;}
    public bool choiceInDisplay = false;
    private static DialogueManager instance;

   // private bool isTalking = false;

    private bool canContinueToNextLine = false;

    private Coroutine displayLineCoroutine;

    private DialogueVariables dialogueVariables;

    
    

    void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Hay m�s de un Dialogue Manager y no deberia");
        }
        instance = this;

        //cargarVariables();
        dialogueVariables = new DialogueVariables(loadGlobalsJSON);
    }

    private void cargarVariables(){
        SetVariable("partir",Globales.partir);
        SetVariable("clinicaDonado",Globales.clinicaDonado);
        SetVariable("paraselva", Globales.paraselva);
        SetVariable("paradesierto", Globales.paradesierto);
        SetVariable("parahielo", Globales.parahielo);
        SetVariable("parafinal", Globales.parafinal);
        SetVariable("cinematicavista", Globales.cinematicavista);
        SetVariable("recursosprueba", Globales.checkRecursosSelva);
        SetVariable("recursosprueba2", Globales.checkRecursosCiudad);
    }
    public static DialogueManager GetInstance()
    {
        return instance;
    }

    void Start()
    {
        dialogueIsPlaying = false;
        dialoguePanel.SetActive(false);
        fondo.SetActive(false);

        choicesText = new TextMeshProUGUI[choices.Length];
        int i = 0;
        foreach (GameObject choice in choices)
        {
            choicesText[i] = choice.GetComponentInChildren<TextMeshProUGUI>();
            i++;
        }
        cargarVariables();
    }

    // Update is called once per frame
    void Update()
    {
        if (!dialogueIsPlaying)
        {
            return;
        }
        else
        {
            ChooseMinigame();
        }

        if (Input.GetMouseButtonDown(0) && !choiceInDisplay)
        {
            Vector3 worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(worldPosition, Vector2.zero);
            if (canContinueToNextLine && hit.collider != null && hit.collider.gameObject.tag != "Interfaz") //Esto se para ver donde se hace click, se deberia cambiar en un futuro
            {
                ContinueStory();
            }
        }
    }

    public void EnterDialogueMode(TextAsset inkJSON)
    {
        currentStory = new Story(inkJSON.text);

        dialogueIsPlaying = true;
        dialoguePanel.SetActive(true);
        fondo.SetActive(true);

        dialogueVariables.StartListening(currentStory);

        ContinueStory();
    }

    private void ExitDialogueMode()
    {
        dialogueVariables.StopListening(currentStory);

        dialogueIsPlaying = false;
        dialoguePanel.SetActive(false);
        fondo.SetActive(false);
        dialogueText.text = "";
    }
   
    private void ContinueStory()
    {
        if (currentStory.canContinue)
        {
            //dialogueText.text = currentStory.Continue();
            if (displayLineCoroutine != null)
            {
                StopCoroutine(displayLineCoroutine);
            }
 
            displayLineCoroutine = StartCoroutine(DisplayLine(currentStory.Continue()));
            //DisplayChoices();

            HandleTags(currentStory.currentTags);
        }
        else
        {
            ExitDialogueMode();
        }
    }

    private void HandleTags(List<string> currentTags)
    {
        foreach (string tag in currentTags)
        {
            //Separamos key del value gracias a los dos puntos ("speaker": Jeringuito)
            string[] splitTag = tag.Split(':'); 
            if (splitTag.Length != 2)
            {
                Debug.LogError("Tag could not be appropriately parsed" + tag);
            }
            string tagKey = splitTag[0].Trim(); //Trim para eliminar posibles espacios en blanco
            string tagValue = splitTag[1].Trim();

            switch (tagKey)
            {
                case SPEAKER_TAG:
                    displayNameText.text = tagValue;
                    break;
                case PORTRAIT_TAG:
                    portraitImage.gameObject.GetComponent<Image>().sprite = spriteArray[int.Parse(tagValue)];
                    break;
                default:
                    break;
            }
        }
    }

    private IEnumerator DisplayLine(string line)
    {
        dialogueText.text = "";
        continueIcon.SetActive(false);
        HideChoices();

        canContinueToNextLine = false;

        bool isAddingRichTextTag = false;

        foreach (char letter in line.ToCharArray())
        {
           // if (Input.GetMouseButtonDown(0))
           // {
            //    dialogueText.text = line;
            //    break;
           // }
            //isTalking = true;

            if (letter == '<' || isAddingRichTextTag)
            {
                isAddingRichTextTag = true;
                dialogueText.text += letter;
                if (letter == '>')
                { 
                    isAddingRichTextTag = false;
                }
            }
            else
            {
                dialogueText.text += letter;
                yield return new WaitForSeconds(typingSpeed);
            }
        }
        continueIcon.SetActive(true);
        //isTalking = false;
        DisplayChoices();

        canContinueToNextLine = true;
        
    }

    private void HideChoices()
    {
        foreach (GameObject choiceButton in choices)
        {
            choiceButton.SetActive(false);
        }
    }

    private void DisplayChoices()
    {
        List<Choice> currentChoices = currentStory.currentChoices;
        choiceInDisplay = true;

        int i = 0;
        foreach(Choice choice in currentChoices)
        {
            choices[i].SetActive(true);
            choicesText[i].text = choice.text;
            i++;
        }

        for(int j = i; j < choices.Length; j++)
        {
            choices[j].SetActive(false);
            choiceInDisplay = false;
        }

    }

    public void MakeChoice(int choiceIndex)
    {
        if (canContinueToNextLine)
        {
            Debug.Log("entra");
            currentStory.ChooseChoiceIndex(choiceIndex);
            ContinueStory();
        }
       
    }


    public Ink.Runtime.Object GetVariableState(string variableName)
    {
        Ink.Runtime.Object variableValue = null;
        dialogueVariables.variables.TryGetValue(variableName, out variableValue);
        if (variableValue == null)
        {
            Debug.LogWarning("Ink Variable was found to be null: " + variableName);
        }
        return variableValue;
    }

    void ChooseMinigame()
    {
        string minijuego = ((Ink.Runtime.StringValue) 
            DialogueManager.GetInstance()
            .GetVariableState("minijuego")).value;

        //SceneManager.LoadScene("Ciudad");

        if (minijuego != "ninguno")
        {
            SceneManager.LoadScene(minijuego);
            ((Ink.Runtime.StringValue)
            DialogueManager.GetInstance()
            .GetVariableState("minijuego")).value = "ninguno";
            ExitDialogueMode();
        }
    }

    public string GetDestino()
    {
        return ((Ink.Runtime.StringValue)
            DialogueManager.GetInstance()
            .GetVariableState("destino")).value;
    }
    //
    public string Getpartir()
    {
        return ((Ink.Runtime.StringValue)
            DialogueManager.GetInstance()
            .GetVariableState("partir")).value;
    }


    public string GetUniversal(string vari)
    {
        return ((Ink.Runtime.StringValue)
            DialogueManager.GetInstance()
            .GetVariableState(vari)).value;
    }

    
    public void SetVariable(string variable, string value){
        ((Ink.Runtime.StringValue)DialogueManager.GetInstance().GetVariableState(variable)).value=value;
    }
    //
    public bool DialoguePlaying()
    {
        return dialogueIsPlaying;
    }

    
}
