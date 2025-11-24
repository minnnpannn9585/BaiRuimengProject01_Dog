using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickCorrect : MonoBehaviour
{
    public GameObject correctText;

    private void OnMouseDown()
    {
        correctText.SetActive(true);
        
        Invoke("LoadNext", 2f);
    }

    void LoadNext()
    {
        SceneManager.LoadScene("14_state02");
    }
}
