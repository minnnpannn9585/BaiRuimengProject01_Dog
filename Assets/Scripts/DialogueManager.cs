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
    
    public bool inDialogue = false;

    private void Awake()
    {
        if (Instance != null)
        {
            return;
        }
        Instance = this;
    }

    private void Start()
    {
        DontDestroyOnLoad(gameObject);
        dialogueUI = transform.GetChild(0).gameObject;
        dialogueText = transform.GetChild(0).GetChild(0).GetComponent<Text>();
    }

    public void StartDialogue()
    {
        dialogueUI.SetActive(true); // Show the dialogue UI
        index = 0;
        dialogueText.text = dialogues[index];
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
