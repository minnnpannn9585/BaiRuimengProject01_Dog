using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickshowerhead : MonoBehaviour
{
    public GameObject showerhead;
    private void OnMouseDown()
    {
        showerhead.SetActive(true);
    }

}
