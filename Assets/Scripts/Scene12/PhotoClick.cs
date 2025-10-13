using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PhotoClick : MonoBehaviour
{
    public GameObject bigphoto;

    public string[] dialogues;
    private void OnMouseDown()
    {
        bigphoto.SetActive(true);
        DialogueManager.Instance.dialogues = dialogues;
        DialogueManager.Instance.StartDialogue();
    }
}
