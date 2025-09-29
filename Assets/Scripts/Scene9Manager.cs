using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene9Manager : MonoBehaviour
{
   

    public GameObject[] busy;
    int index = 1;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            

            if (index >= busy.Length)
            {
                index = 0;
                //foreach (GameObject busy in busy)
                //{
                //    busy.SetActive(false);
                //}
                SceneManager.LoadScene("10");
                return;

               
            }
            ShowPicture(index);
            index++;
        }
    }

    public void ShowPicture(int i)
    {
        foreach (GameObject busy in busy)
        {
            busy.SetActive(false);
        }
        busy[i].SetActive(true);
        
    }
}
