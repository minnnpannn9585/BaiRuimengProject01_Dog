using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishPlants : MonoBehaviour
{
    public int numberFinish = 0;
    public PolygonCollider2D dogCollider;
    public bool canClick = false;
    public DialogueManager dm;
    public string[] dialogues;


    public void AddNumber()
    {
        numberFinish++;

        if(numberFinish == 3)
        {
            dogCollider.enabled = true;
            dm.dialogues = dialogues;
            dm.StartDialogue();
        }
    }
}
