using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class clickmeat : MonoBehaviour
{
    public int numberFinish = 0;
    public int totalMeat = 5;


    public string nextSceneName = "NextScene";
    public void AddNumber()
    {
        numberFinish++;

        if (numberFinish >= totalMeat)
        {

            SceneManager.LoadScene(nextSceneName);
        }
    }
}
