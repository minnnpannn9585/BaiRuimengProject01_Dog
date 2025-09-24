using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickObjToLoadLevel : MonoBehaviour
{
    private void OnMouseDown()
    {
        if(!DialogueManager.Instance.inDialogue)
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
