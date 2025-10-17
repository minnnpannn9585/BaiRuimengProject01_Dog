using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickPackage1 : MonoBehaviour
{
    public GameObject package;

    //public string[] dialogues;
    private void OnMouseDown()
    {
        if (DialogueManager.Instance.inDialogue) return;
        
        this.gameObject.SetActive(false);
        package.SetActive(true);

    }

}
