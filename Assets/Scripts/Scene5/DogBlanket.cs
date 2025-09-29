using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogBlanket : MonoBehaviour
{
    
    public GameObject dog1;
    public GameObject dog2;
    public GameObject duo;
    public GameObject blancket;

    public string[] dialogues;

    private void OnMouseDown()
    {

        this.gameObject.SetActive(false);
        dog1.SetActive(true);
        dog2.SetActive(true);
        duo.SetActive(false);
        blancket.AddComponent<PolygonCollider2D>();

        DialogueManager.Instance.dialogues = dialogues;
        DialogueManager.Instance.StartDialogue();
    }

}