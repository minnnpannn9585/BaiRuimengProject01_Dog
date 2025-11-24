using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickInccorect : MonoBehaviour
{

    public GameObject wrong;

    private void OnMouseDown()
    {
        wrong.SetActive(true);

    }
}