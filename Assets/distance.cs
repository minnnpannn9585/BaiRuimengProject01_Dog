using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class distance : MonoBehaviour
{
    public GameObject[] busy;
    int index = 0;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (index >= busy.Length)
            {
                index = 0;
                foreach (GameObject busy in busy)
                {
                    busy.SetActive(false);
                }
                return;
            }
            busy[index].SetActive(true);
            index++;
        }
    }
}
