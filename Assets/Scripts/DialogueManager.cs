using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public GameObject dialogueUI;
    public Text dialogueText;
    public int index;
    public string[] dialogues;

    public void StartDialogue()
    {
        dialogueUI.SetActive(true); // Show the dialogue UI
        index = 0;
        dialogueText.text = dialogues[index];
    }

    public void DisplayNextSentence()
    {
        print(111);
        index++;
        if (index >= dialogues.Length)
        {
            print(222);
            index = 0;
            dialogueUI.SetActive(false);
            dialogues = new string[0];
        }
        else
        {
            dialogueText.text = dialogues[index];
        }
    }
}
