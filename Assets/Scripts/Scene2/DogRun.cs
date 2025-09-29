using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogRun : MonoBehaviour
{
    bool firstTime = true;
    public GameObject crawl;
    
    public string[] dialogues;


    private void OnMouseDown()
    {
        if (DialogueManager.Instance.inDialogue)
        {
            return;
        }
        if (firstTime)
        {
            GetComponent<Animator>().SetTrigger("RUN");
            GetComponent<PolygonCollider2D>().enabled = false;
            StartCoroutine(TurnOffSwitch());
        }
        else
        {
            crawl.SetActive(true);

            DialogueManager.Instance.dialogues = dialogues;
            DialogueManager.Instance.StartDialogue();
            
            this.gameObject.SetActive(false);
            

        }

    }

    IEnumerator TurnOffSwitch()
    {
        yield return new WaitForSeconds(2f);
        firstTime = false;
        GetComponent<PolygonCollider2D>().enabled = true;
    }

}

