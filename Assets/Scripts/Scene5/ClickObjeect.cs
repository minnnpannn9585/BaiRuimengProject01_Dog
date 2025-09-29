using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickObjeect : MonoBehaviour
{

    public GameObject cotton;

    private void OnMouseDown()
    {
        cotton.SetActive(true);
    }


}
