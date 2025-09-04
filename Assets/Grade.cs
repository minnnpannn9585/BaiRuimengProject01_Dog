using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grade : MonoBehaviour
{
    public GameObject[] score;
    int index = 0;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (index >= score.Length)
            {
                index = 0;
                foreach (GameObject score in score)
                {
                    score.SetActive(false);
                }
                return;
            }
            score[index].SetActive(true);
            index++;
        }
    }
}
