using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene1204Manager : MonoBehaviour
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
               
                return;
            }
            score[index].SetActive(false);
            index++;
        }
    }
}
