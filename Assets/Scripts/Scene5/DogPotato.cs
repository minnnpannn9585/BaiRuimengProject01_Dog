using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DogPotato : MonoBehaviour
{
    public GameObject potato;


    private void OnMouseDown()
    {
        this.gameObject.SetActive(false);
        potato.SetActive(true);
    }

}