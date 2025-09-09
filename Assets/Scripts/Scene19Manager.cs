using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tear : MonoBehaviour
{
    public GameObject[] tears;
    int index = 0;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (index >= tears.Length)
            {
                SceneManager.LoadScene("20");
                index = 0;
                //foreach (GameObject book in books)
                //{
                //    book.SetActive(false);
                //}
                return;
            }
            tears[index].SetActive(false);
            index++;
        }
    }
}
