using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Clickdog2 : MonoBehaviour
{
    public GameObject Dog3;

    private void OnMouseDown()
    {
        Dog3.SetActive(true);
        this.gameObject.SetActive(false);
    }
}
