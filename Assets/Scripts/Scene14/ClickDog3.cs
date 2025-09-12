using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickDog3 : MonoBehaviour
{
    public GameObject dog4;
    public GameObject cake;

    private void OnMouseDown()
    {
        dog4.SetActive(true);
        cake.SetActive(true);
        this.gameObject.SetActive(false);   
    }
}
