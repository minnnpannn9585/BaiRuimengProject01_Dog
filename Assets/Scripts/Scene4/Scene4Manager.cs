using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class clickdog : MonoBehaviour
{
    public GameObject dog;


    private void OnMouseDown()
    {
        this.gameObject.SetActive(false);
        dog.SetActive(true);
    }

}