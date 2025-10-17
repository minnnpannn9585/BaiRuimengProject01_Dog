using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Picture : MonoBehaviour
{
    public GameObject bigpicture;
    public GameObject dog;
    public string[] dialogues;
    private void OnMouseDown()
    {
        bigpicture.SetActive(true);
        dog.AddComponent<PolygonCollider2D>();
        DialogueManager.Instance.dialogues = dialogues;
        DialogueManager.Instance.StartDialogue();
    }
}
