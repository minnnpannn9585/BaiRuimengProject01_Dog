using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene1Manager : MonoBehaviour
{
    public GameObject Down;


    private void OnMouseDown()
    {
        this.gameObject.SetActive(false);
        Down.SetActive(true);
    
    }

}
