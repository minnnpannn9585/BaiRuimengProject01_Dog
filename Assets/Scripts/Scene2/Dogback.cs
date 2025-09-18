using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class clickback : MonoBehaviour
{
    public GameObject roll;


    private void OnMouseDown()
    {
        this.gameObject.SetActive(false);
        roll.SetActive(true);
       
    }

}

