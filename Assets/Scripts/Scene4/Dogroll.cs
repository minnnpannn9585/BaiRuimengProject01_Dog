using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dogroll : MonoBehaviour
{
    bool firstTime = true;
    public GameObject back;

    public string[] dialogues;


    private void OnMouseDown()
    {
        if (!firstTime)
        {

            DialogueManager.Instance.dialogues = dialogues;
            DialogueManager.Instance.StartDialogue();
            back.SetActive(true);
            Destroy(gameObject);
        }
        else
        {
            GetComponent<Animator>().SetTrigger("roll2");
            firstTime = false;
            StartCoroutine(TurnOffSwitch());
        }

    }
    IEnumerator TurnOffSwitch()
    {
        yield return new WaitForSeconds(2f);
        firstTime = false;
        GetComponent<PolygonCollider2D>().enabled = true;
    }
}

