using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickBigtips : MonoBehaviour
{
    public GameObject tips;

    private void OnMouseDown()
    {
        this.gameObject.SetActive(false);
        tips.SetActive(true);
    }
}