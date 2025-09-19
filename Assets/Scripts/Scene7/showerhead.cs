
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class FollowMouseX : MonoBehaviour
{
    void Update()
    {
        
        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        transform.position = new Vector3(mousePosition.x, transform.position.y, transform.position.z);
    }
}

public class PlayerController : MonoBehaviour
{
    private GameObject currentTarget;   
    private int destroyedTargets = 0;   
    public int totalTargets = 4;
    public GameObject water;


        private void OnMouseDown()
        {
            if (currentTarget != null)  
            {
                Destroy(currentTarget);  
                destroyedTargets++;    
                currentTarget = null;    

                if (destroyedTargets >= totalTargets)
                {
                    Destroy(gameObject);
                water.gameObject.SetActive(true);
                }
            }
        }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("target"))
        {
            currentTarget = other.gameObject;
        }
    }


    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("target") && other.gameObject == currentTarget)
        {
            currentTarget = null;
        }
    }

}

