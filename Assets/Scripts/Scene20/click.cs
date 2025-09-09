using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class click : MonoBehaviour
{
    public GameObject left;
    public GameObject right;

    private void OnMouseDown()
    {
        left.SetActive(true);
        right.SetActive(true);
    }

}
