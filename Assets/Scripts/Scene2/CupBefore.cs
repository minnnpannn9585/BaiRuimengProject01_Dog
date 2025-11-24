using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

public class CupBefore : MonoBehaviour
{
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
}
