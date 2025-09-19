using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishWater : MonoBehaviour
{
    public int numberFinish = 0;
    public GameObject water;
    public GameObject loadNext;

    public void AddNumber()
    {
        numberFinish++;

        if (numberFinish == 4)
        {
            water.SetActive(true);
            loadNext.SetActive(true);
        }
    }
}