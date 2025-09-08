using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Click4 : MonoBehaviour
{
    public GameObject fouropen;

    private void OnMouseDown()
    {
        this.gameObject.SetActive(false);
        fouropen.SetActive(true);
    }

}
