using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Click3 : MonoBehaviour
{
    public GameObject threeopen;

    private void OnMouseDown()
    {
        this.gameObject.SetActive(false);
        threeopen.SetActive(true);
    }

}
