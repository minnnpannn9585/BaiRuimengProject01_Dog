using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finishwater : MonoBehaviour
{
    public int numberFinish = 0;
    public PolygonCollider2D waterCollider;

    public void AddNumber()
    {
        numberFinish++;

        if (numberFinish == 4)
        {
            waterCollider.enabled = true;
        }
    }
}