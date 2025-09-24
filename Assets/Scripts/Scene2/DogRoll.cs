using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogRoll : MonoBehaviour
{
    bool firstTime = true;
    public GameObject cookieGame;
    
    public string[] dialogues;

    private void OnMouseDown()
    {
        if (DialogueManager.Instance.inDialogue)
        {
            return;
        }
        
        if (firstTime)
        {
            GetComponent<Animator>().SetTrigger("roll");
            firstTime = false;
        }
        else
        {
            cookieGame.SetActive(true);
            


            DialogueManager.Instance.dialogues = dialogues;
            DialogueManager.Instance.StartDialogue();
            
            this.gameObject.SetActive(false);
        }
        
    }
}
