using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogClick : MonoBehaviour
{
    public GameObject photo;

    public string[] dialogues;

    private void OnMouseDown()
    {
        transform.parent.GetComponent<Animator>().SetTrigger("walk");
        StartCoroutine(EndAnimation());
        DialogueManager.Instance.dialogues = dialogues;
        DialogueManager.Instance.StartDialogue();
    }

    IEnumerator EndAnimation()
    {
        yield return new WaitForSeconds(2f);
        photo.AddComponent<PolygonCollider2D>();
    }
}
