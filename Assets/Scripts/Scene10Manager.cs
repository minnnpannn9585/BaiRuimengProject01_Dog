using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene10Manager : MonoBehaviour
{
    public GameObject[] score;
    int index = 1;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (index >= score.Length)
            {
                index = 0;
                //foreach (GameObject score in score)
                //{
                //    score.SetActive(false);
                //}
                SceneManager.LoadScene("11");
                return;
            }
            score[index].SetActive(true);
            index++;
        }
    }
}
