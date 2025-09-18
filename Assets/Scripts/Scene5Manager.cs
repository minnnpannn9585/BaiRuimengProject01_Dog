
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class next : MonoBehaviour
{
    public GameObject Next;
    

    private void OnMouseDown()
    {
        this.gameObject.SetActive(false);
        Next.SetActive(true);
    }

}