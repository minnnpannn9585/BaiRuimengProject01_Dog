using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scene12StartDia : MonoBehaviour
{
    public string[] sentences;
    // Start is called before the first frame update
    void Start()
    {
        DialogueManager.Instance.dialogues = sentences;
        DialogueManager.Instance.StartDialogue();
    }
    
}
