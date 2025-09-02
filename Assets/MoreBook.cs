using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
                index = 0;
                foreach (GameObject book in books)
                {
                    book.SetActive(false);
                }
                return;
            }
            books[index].SetActive(true);
            index++;   
        }
    }
}
