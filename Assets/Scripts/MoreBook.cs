using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoreBook : MonoBehaviour
{
    public GameObject[] books;
    int index = 0;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
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
            index++;   
        }
    }
}
