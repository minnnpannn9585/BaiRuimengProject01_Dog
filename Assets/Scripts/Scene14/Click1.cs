using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Click1 : MonoBehaviour
{
    public GameObject oneopen;

    private void OnMouseDown()
    {
        this.gameObject.SetActive(false);
        oneopen.SetActive(true);
    }

}
