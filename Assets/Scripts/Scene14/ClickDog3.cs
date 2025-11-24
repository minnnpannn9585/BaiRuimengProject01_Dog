using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickDog3 : MonoBehaviour
{
    private void OnMouseDown()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("14_state01cake");
    }
}
