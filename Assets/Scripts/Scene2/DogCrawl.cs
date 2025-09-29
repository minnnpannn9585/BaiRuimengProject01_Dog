using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DogCrawl : MonoBehaviour
{
    public GameObject cookieGame;
    public float moveSpeed = 5f;
    public float offscreenY = -10f;

    private bool isMoving = false;
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {

            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            Collider2D hit = Physics2D.OverlapPoint(mousePos);
            if (hit != null && hit.gameObject == gameObject)
            {
                isMoving = true;
            }
        }

        if (isMoving)
        {
            transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);

            if (transform.position.y <= offscreenY)
            {
                gameObject.SetActive(false);

                if (cookieGame != null)
                {
                    cookieGame.SetActive(true);
                }

                isMoving = false;
            }
        }
    }
}

