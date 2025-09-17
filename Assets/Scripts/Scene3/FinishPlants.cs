using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishPlants : MonoBehaviour
{
    public int numberFinish = 0;
    public PolygonCollider2D dogCollider;

    public void AddNumber()
    {
        numberFinish++;

        if(numberFinish == 3)
        {
            dogCollider.enabled = true;
        }
    }
}
