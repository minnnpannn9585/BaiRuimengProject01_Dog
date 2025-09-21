using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogRoll : MonoBehaviour
{
    bool firstTime = true;
    public GameObject cookieGame;
    public DialogueManager dm;
    public string[] dialogues;

    private void OnMouseDown()
    {
        if (firstTime)
        {
            GetComponent<Animator>().SetTrigger("roll");
            firstTime = false;
        }
        else
        {
            cookieGame.SetActive(true);
            Destroy(gameObject);


            dm.dialogues = dialogues;
            dm.StartDialogue();
        }
        
    }
}
