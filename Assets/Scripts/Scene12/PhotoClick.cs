using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotoClick : MonoBehaviour
{
    public GameObject bigphoto;
    private void OnMouseDown()
    {
        bigphoto.SetActive(true);
    }
}
