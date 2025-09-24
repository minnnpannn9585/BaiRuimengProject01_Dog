using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Clickfence : MonoBehaviour
{
    bool firstTime = true;
    public int numberFinish = 0;
    public PolygonCollider2D duoCollider; 

    public string[] dialogues;


    private void OnMouseDown()
    {
        if (DialogueManager.Instance.inDialogue)
        {
            return;
        }
        if (firstTime)
        {
            DialogueManager.Instance.dialogues = dialogues;
            DialogueManager.Instance.StartDialogue();
            //StartCoroutine(TurnOffSwitch());
            firstTime = false;
            duoCollider.enabled = true;
        }
        this.gameObject.SetActive(false);
      
    }
    
    IEnumerator TurnOffSwitch()
    {
        firstTime = false;
        yield return new WaitForSeconds(0.2f);
        
        duoCollider.enabled = true;
    }
}