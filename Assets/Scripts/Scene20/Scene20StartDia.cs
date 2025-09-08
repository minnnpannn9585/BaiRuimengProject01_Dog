using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene20StartDia : MonoBehaviour
{
    public DialogueManager dm;
    public string[] sentences;
    // Start is called before the first frame update
    void Start()
    {
        dm.dialogues = sentences;
        dm.StartDialogue();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            dm.DisplayNextSentence();
        }
    }
}
