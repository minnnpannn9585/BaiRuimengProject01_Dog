using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fence : MonoBehaviour
{
    public int numberFinish = 0;
    public PolygonCollider2D DuoCollider;


    private void OnMouseDown()
    {
        this.gameObject.SetActive(false);

    }

    public void AddNumber()
    {
        numberFinish++;

        if (numberFinish == 1)
        {
            DuoCollider.enabled = true;
        }
    }
}