using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Flower : MonoBehaviour
{

    [Header("flowers")]
    public GameObject[] objectsToDrop;  

    [Header("speed")]
    public float minSpeed = 2f;   
    public float maxSpeed = 6f;   
    [Header("scene")]
    public string nextSceneName = "NextScene";

    private bool hasClicked = false;
    private int finishedCount = 0; 

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !hasClicked)
        {
            hasClicked = true;
            StartDrop();
        }
    }

    void StartDrop()
    {
        foreach (GameObject obj in objectsToDrop)
        {
            float speed =UnityEngine.Random.Range(minSpeed, maxSpeed);
            StartCoroutine(DropObject(obj, speed));
        }
    }

    IEnumerator DropObject(GameObject obj, float speed)
    {
        float screenBottom = Camera.main.ScreenToWorldPoint(new Vector3(0, 0, 0)).y;

        while (obj != null && obj.transform.position.y > screenBottom - 1f)
        {
            obj.transform.position += Vector3.down * speed * Time.deltaTime;
            yield return null;
        }

        finishedCount++;


        if (finishedCount >= objectsToDrop.Length)
        {
            SceneManager.LoadScene(nextSceneName);
        }
    }
}
