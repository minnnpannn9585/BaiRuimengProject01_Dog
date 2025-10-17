using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Clickdog1 : MonoBehaviour
{
    public GameObject imagine;
    public string[] dialogues;

    private void OnMouseDown()
    {
        imagine.SetActive(true);
        DialogueManager.Instance.dialogues = dialogues;
        DialogueManager.Instance.StartDialogue();
    }
}
