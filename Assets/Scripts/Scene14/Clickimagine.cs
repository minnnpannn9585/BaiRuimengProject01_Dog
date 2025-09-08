using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Clickimagine : MonoBehaviour
{
    public GameObject imagine;

    private void OnMouseDown()
    {
        imagine.SetActive(false);
    }
}
