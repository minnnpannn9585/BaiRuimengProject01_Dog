using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSlider : MonoBehaviour
{
    private bool isMoving = true;
    Transform startPos;
    Transform endPos;
    private bool toEnd = true;
    public float speed;
    Vector3 toEndDir;
    private bool win = false;

    public GameObject wintext;
    public GameObject losetext;
    
    public Animator doorAnimator;
    public GameObject loadLevelObj;
    public GameObject swimsuit;
    public GameObject put;
    
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.parent.GetChild(3);
        endPos = transform.parent.GetChild(4);
        toEndDir = endPos.position - startPos.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (DialogueManager.Instance.inDialogue)
        {
            return;
        }
        if (isMoving)
        {
            if (toEnd)
            {
                transform.Translate(toEndDir.normalized * Time.deltaTime * speed);
                if (Vector3.Distance(transform.position, endPos.position) <= 0.21f)
                {
                    toEnd = false;
                }
            }
            else
            {
                transform.Translate(-toEndDir.normalized * Time.deltaTime * speed);
                if (Vector3.Distance(transform.position, startPos.position) <= 0.21f)
                {
                    toEnd = true;
                    put.SetActive(true);
                    swimsuit.SetActive(false);
                }
            }
        }
        

        if (Input.GetKeyDown(KeyCode.Space))
        {
            loadLevelObj.SetActive(true);
            doorAnimator.speed = 0;
            isMoving = false;
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
