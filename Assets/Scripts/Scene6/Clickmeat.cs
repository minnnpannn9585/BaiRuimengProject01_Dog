using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickmeat : MonoBehaviour
{
    public int numberFinish = 0;
    public PolygonCollider2D bowlCollider;

    public void AddNumber()
    {
        numberFinish++;

        if (numberFinish == 5)
        {
            bowlCollider.enabled = true;
        }
    }
}
