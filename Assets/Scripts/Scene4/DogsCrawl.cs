using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class DogsCrawl : MonoBehaviour

{
    public float moveSpeed = 2f;
    public string nextSceneName = "Next";
    private bool isMoving = false;

    void OnMouseDown()
    {
        if (!isMoving)
        {
            StartCoroutine(MoveDownAndChangeScene());
        }
    }

    private System.Collections.IEnumerator MoveDownAndChangeScene()
    {
        isMoving = true;


        float screenBottom = Camera.main.ScreenToWorldPoint(new Vector3(0, 0, 0)).y;

        while (transform.position.y > screenBottom - 1f)
        {
            transform.position += Vector3.down * moveSpeed * Time.deltaTime;
            yield return null;
        }

        SceneManager.LoadScene(nextSceneName);
    }
}