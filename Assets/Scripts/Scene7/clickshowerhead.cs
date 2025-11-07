using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickshowerhead : MonoBehaviour
{
    public GameObject showerhead;
    public bool isClicked = false;
    public string[] dialogues;


    private void OnMouseDown()
    {
        if (DialogueManager.Instance.inDialogue)
        {
            return;
        }

        if (!isClicked)
        {
            DialogueManager.Instance.dialogues = dialogues;
            DialogueManager.Instance.StartDialogue();
        }

            

        showerhead.SetActive(true);
        isClicked = true;

        
    }

}
