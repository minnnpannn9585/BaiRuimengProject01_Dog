using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogRun : MonoBehaviour
{
    bool firstTime = true;
    public GameObject back;

    private void OnMouseDown()
    {
        if (firstTime)
        {
            GetComponent<Animator>().SetTrigger("RUN");
            firstTime = false;
        }
        else
        {
            this.gameObject.SetActive(false);
            back.SetActive(true);

         
        }

    }

}

