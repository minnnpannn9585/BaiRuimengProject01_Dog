using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager03 : MonoBehaviour

{

    public string[] sceneStartDialogues;
    void Start()
    {
        DialogueManager.Instance.dialogues = sceneStartDialogues;
        DialogueManager.Instance.StartDialogue();
    }


}
