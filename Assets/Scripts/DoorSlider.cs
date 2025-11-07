using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSlider : MonoBehaviour
{
    private bool win = false;

    public GameObject wintext;
    public GameObject losetext;
    
    public Animator doorAnimator;
    Animator pointAnimator;
    public GameObject loadLevelObj;
    public GameObject swimsuit;
    public GameObject put;

    private void Awake()
    {
        pointAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (DialogueManager.Instance.inDialogue)
        {
            return;
        }

        pointAnimator.SetTrigger("StartSwing");



        if (Input.GetKeyDown(KeyCode.Space))
        {
            loadLevelObj.SetActive(true);
            pointAnimator.speed = 0;
            doorAnimator.speed = 0;
            if (win)
            {
                wintext.SetActive(true);
				//switch dog image
            }
            else
            {
                losetext.SetActive(true);
            }
        }
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
