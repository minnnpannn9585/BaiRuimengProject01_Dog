using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

public class CupBefore : MonoBehaviour
{
    public Vector3 normalScale = Vector3.one * 0.93f;
    public Vector3 hoverScale = Vector3.one * 1.2f;
    public float scaleSpeed = 8f;

    private Coroutine scaleCoroutine;

    public GameObject[] newCups;
    [HideInInspector]
    public GameObject[] oldCups = new GameObject[3];
    public GameObject cookie;
    public Transform[] cupTrans;

    public int index;
    public DogGoToCookie dogGo;

    private void Start()
    {
        for (int i = 0; i < newCups.Length; i++)
        {
            oldCups[i] = transform.parent.GetChild(i + 1).gameObject;
        }
    }

    private void OnMouseDown()
    {
        if(DialogueManager.Instance.inDialogue)
            return;
        
        cookie.SetActive(false);
        for(int i = 0; i < newCups.Length; i++)
        {
            newCups[i].SetActive(true);
            oldCups[i].SetActive(false);
        }
        dogGo.DogGoTo(cupTrans[index].position);
    }

    void OnMouseEnter()
    {
        if(DialogueManager.Instance.inDialogue)
            return;
        StartScale(hoverScale);
    }

    void OnMouseExit()
    {
        if(DialogueManager.Instance.inDialogue)
            return;
        StartScale(normalScale);
    }

    void StartScale(Vector3 targetScale)
    {
        if (scaleCoroutine != null)
            StopCoroutine(scaleCoroutine);
        scaleCoroutine = StartCoroutine(ScaleTo(targetScale));
    }

    System.Collections.IEnumerator ScaleTo(Vector3 target)
    {
        while (Vector3.Distance(transform.localScale, target) > 0.01f)
        {
            transform.localScale = Vector3.Lerp(transform.localScale, target, scaleSpeed * Time.deltaTime);
            yield return null;
        }
        transform.localScale = target;
    }
}
