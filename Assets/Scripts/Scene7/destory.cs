using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class destory : MonoBehaviour
{
    private void OnMouseDown()
    {
        this.gameObject.SetActive(false);
    }
}