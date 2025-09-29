using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DogPotato : MonoBehaviour
{
    public GameObject potato;
    public GameObject slipper1;
    public GameObject slipper2;

    public string[] dialogues;

    private void OnMouseDown()
    {
    
        potato.SetActive(true);
        slipper1.SetActive(false);
        slipper2.SetActive(true);
        DialogueManager.Instance.dialogues = dialogues;
        DialogueManager.Instance.StartDialogue();
    }

}