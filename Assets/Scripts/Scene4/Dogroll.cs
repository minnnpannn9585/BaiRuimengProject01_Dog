using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dogroll : MonoBehaviour
{
    bool firstTime = true;
    public GameObject back;

    private void OnMouseDown()
    {
        if (firstTime)
        {
            GetComponent<Animator>().SetTrigger("roll2");
            firstTime = false;
        }
        else
        {
            back.SetActive(true);
            Destroy(gameObject);
        }

    }
}

