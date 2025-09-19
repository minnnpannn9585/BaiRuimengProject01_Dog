using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DestroyDirt : MonoBehaviour
{
    public FinishWater finishWater;
    public clickshowerhead clickshowerhead;
    private void OnMouseDown()
    {
        if (clickshowerhead.isClicked)
        {
            this.gameObject.SetActive(false);
            finishWater.AddNumber();
        }
        
    }
}