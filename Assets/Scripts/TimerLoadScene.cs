using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimerLoadScene : MonoBehaviour
{
    //public string sceneToLoad;
    public float timer;
    
    
    void Update()
    {
        timer-=Time.deltaTime;
        if (timer <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
