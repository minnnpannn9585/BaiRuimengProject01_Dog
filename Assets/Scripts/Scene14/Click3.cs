using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Click3 : MonoBehaviour
{
    public GameObject threeopen;
    public GameObject dogopen;
    public GameObject dogclose;

    private void OnMouseDown()
    {
        this.gameObject.SetActive(false);
        dogclose.SetActive(false);
        threeopen.SetActive(true);
        dogopen.SetActive(true);
    }

}
