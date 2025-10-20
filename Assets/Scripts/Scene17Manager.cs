using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class book : MonoBehaviour
{
    public GameObject[] books;
    int index = 0;



    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
           
            if (index >= books.Length)
            {
                SceneManager.LoadScene("18");
                index = 0;
                //foreach (GameObject book in books)
                //{
                //    book.SetActive(false);
                //}
                return;
            }
            books[index].SetActive(false);
            index++;
        }
    }
}