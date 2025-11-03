using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickTips : MonoBehaviour
{
    public GameObject BigTips;


    private void OnMouseDown()
    {
        this.gameObject.SetActive(false);
        BigTips.SetActive(true);

    }

}

