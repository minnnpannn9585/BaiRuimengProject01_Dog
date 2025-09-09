using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickPackage : MonoBehaviour
{
    public GameObject package;


    private void OnMouseDown()
    {
        this.gameObject.SetActive(false);
        package.SetActive(true);
    }

}
