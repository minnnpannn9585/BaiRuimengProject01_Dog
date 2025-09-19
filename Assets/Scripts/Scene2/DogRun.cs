using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogRun : MonoBehaviour
{
    bool firstTime = true;
    public GameObject back;
    public DialogueManager dm;
    public string[] dialogues;


    private void OnMouseDown()
    {
        if (firstTime)
        {
            GetComponent<Animator>().SetTrigger("RUN");
            GetComponent<PolygonCollider2D>().enabled = false;
            StartCoroutine(TurnOffSwitch());
        }
        else
        {
            this.gameObject.SetActive(false);
            back.SetActive(true);

            dm.dialogues = dialogues;
            dm.StartDialogue();

        }

    }

    IEnumerator TurnOffSwitch()
    {
        yield return new WaitForSeconds(2f);
        firstTime = false;
        GetComponent<PolygonCollider2D>().enabled = true;
    }

}

