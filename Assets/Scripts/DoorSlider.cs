using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Callbacks;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorSlider : MonoBehaviour
{
    private bool win = false;

    public GameObject wintext;
    public GameObject losetext;
    
    Animator doorAnimator;
    public GameObject loadLevelObj;
    public GameObject swimsuit;
    public GameObject put;

    private void Awake()
    {
        doorAnimator = transform.parent.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (DialogueManager.Instance.inDialogue)
        {
            return;
        }

        doorAnimator.SetTrigger("StartSwing");



        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            doorAnimator.speed = 0;
            if (win)
            {
                swimsuit.SetActive(false);
                put.SetActive(true);
                loadLevelObj.SetActive(true);
                wintext.SetActive(true);
				//switch dog image
            }
            else
            {
                losetext.SetActive(true);
                Invoke("ReloadScene", 1f);
            }
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Green")
        {
            win = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Green")
        {
            win = false;
        }
    }
    
    
}
