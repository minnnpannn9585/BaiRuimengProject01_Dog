using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public static DialogueManager Instance;
    
    [HideInInspector]
    public GameObject dialogueUI;
    [HideInInspector]
    public Text dialogueText;
    [HideInInspector]
    public int index;
    [HideInInspector]
    public string[] dialogues;
    [HideInInspector]
    public bool inDialogue = false;
    
    public bool hasStartDialogue;

    private void Awake()
    {
        if (Instance != null)
        {
            return;
        }
        Instance = this;

        if (hasStartDialogue)
        {
            inDialogue = true;
        }
        else
        {
            inDialogue = false;
        }

        dialogueUI = transform.GetChild(0).gameObject;
        dialogueText = transform.GetChild(0).GetComponent<Text>();

    }


    private void Update()
    {
        if(inDialogue && Input.GetMouseButtonDown(0))
        {
            DisplayNextSentence();
        }
    }

    public void StartDialogue()
    {
        //inDialogue = true;
        dialogueUI.SetActive(true);
        index = 0;
        dialogueText.text = dialogues[index];
        StartCoroutine(EnableDialogueNextFrame());
    }

    private IEnumerator EnableDialogueNextFrame()
    {
        yield return null;
        inDialogue = true;
    }

    public void DisplayNextSentence()
    {
        
        index++;
        if (index >= dialogues.Length)
        {
            inDialogue = false;
            index = 0;
            dialogueUI.SetActive(false);
            dialogues = Array.Empty<string>();
        }
        else
        {
            dialogueText.text = dialogues[index];
        }
    }
}
