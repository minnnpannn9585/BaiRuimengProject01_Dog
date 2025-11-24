using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickCorrect : MonoBehaviour
{
    public GameObject green;

    private void OnMouseDown()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("14_state02");
    }
}
