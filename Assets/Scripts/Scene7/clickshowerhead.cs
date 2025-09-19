using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickshowerhead : MonoBehaviour
{
    public GameObject showerhead;
    public bool isClicked = false;

    private void OnMouseDown()
    {
        showerhead.SetActive(true);
        isClicked = true;
    }

}
