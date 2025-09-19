using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ClickAnyToLoadLevel : MonoBehaviour
{
    //public string sceneName;
    private float cd = 0.5f;
    
    private void Update()
    {
        cd -= Time.deltaTime;
        if (cd <= 0)
        {
            if (Input.GetMouseButtonDown(0))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
                
        }
        
    }
}
