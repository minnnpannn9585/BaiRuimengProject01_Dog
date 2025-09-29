using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene11Manager : MonoBehaviour
{
    public GameObject doorClose;
    public GameObject doorOpen;

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            doorClose.SetActive(true);
            doorOpen.SetActive(false);
            StartCoroutine(LoadNextScene());
        }
    }

    IEnumerator LoadNextScene()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("12_state01");
    }
}
