using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoreBook : MonoBehaviour
{
    public GameObject[] books;
    int index = 0;
    public bool canClick;

    public string[] dialogues01;
    public string[] dialogues02;
    public string[] dialogues03;
    public string[] dialogues04;

    private Dictionary<int, string[]> dialogueDict;

    void Start()
    {
        dialogueDict = new Dictionary<int, string[]>
        {
            { 0, dialogues01 },
            { 1, dialogues02 },
            { 2, dialogues03 },
            { 3, dialogues04 }
        };
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && canClick)
        {
            if (index >= books.Length)
            {
                SceneManager.LoadScene("9");
                index = 0;
                //foreach (GameObject book in books)
                //{
                //    book.SetActive(false);
                //}
                return;
            }
            books[index].SetActive(true);

            if (dialogueDict.ContainsKey(index))
            {
                DialogueManager.Instance.dialogues = dialogueDict[index];
                DialogueManager.Instance.StartDialogue();
            }
            index++;   
        }
    }
}
