using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dogclick : MonoBehaviour
{
    public GameObject picturedog;

    private void OnMouseDown()
    {
        picturedog.SetActive(true);
    }
}
