using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Picture : MonoBehaviour
{
    public GameObject bigpicture;
    private void OnMouseDown()
    {
        bigpicture.SetActive(true);
    }
}
