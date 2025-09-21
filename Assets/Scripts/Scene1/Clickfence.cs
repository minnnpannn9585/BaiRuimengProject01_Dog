using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Clickfence : MonoBehaviour
{
    bool firstTime = true;
    public int numberFinish = 0;
    public PolygonCollider2D DuoCollider;
    public DialogueManager dm;
    public string[] dialogues;
    public bool canClick = false;


    private void OnMouseDown()
    {
        if (firstTime)
        {
            dm.dialogues = dialogues;
            dm.StartDialogue();
            StartCoroutine(TurnOffSwitch());
        }
        this.gameObject.SetActive(false);
      
    }

    public void AddNumber()
    {
        numberFinish++;

        if (numberFinish == 1)
        {
            DuoCollider.enabled = true;

        }
    }
    IEnumerator TurnOffSwitch()
    {
        yield return new WaitForSeconds(2f);
        firstTime = false;
        GetComponent<PolygonCollider2D>().enabled = true;
    }
}