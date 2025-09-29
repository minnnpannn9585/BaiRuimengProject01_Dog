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
        showerhead.SetActive(true);
        isClicked = true;

        DialogueManager.Instance.dialogues = dialogues;
        DialogueManager.Instance.StartDialogue();
    }

}
