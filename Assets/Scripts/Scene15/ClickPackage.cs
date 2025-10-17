using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickPackage : MonoBehaviour
{
    public GameObject package;

    public string[] dialogues;
    private void OnMouseDown()
    {
        this.gameObject.SetActive(false);
        package.SetActive(true);
        DialogueManager.Instance.dialogues = dialogues;
        DialogueManager.Instance.StartDialogue();
    }

}
