using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public float timeLimit = 5f;        
    private float timeLeft;

    public Text timerText;              
    public Text resultText;             
    public GameObject[] meats;          

    private bool gameEnded = false;

    void Start()
    {
        timeLeft = timeLimit;
        resultText.text = "";
    }

    void Update()
    {
        if (gameEnded) return;

        timeLeft -= Time.deltaTime;
        timerText.text = "Time: " + Mathf.Ceil(timeLeft).ToString();

        if (AllMeatEaten())
        {
            GameWin();
        }

        if (timeLeft <= 0f && !gameEnded)
        {
            GameFail();
        }
    }

    bool AllMeatEaten()
    {
        foreach (var m in meats)
        {
            if (m != null && m.activeSelf)
                return false;
        }
        return true;
    }

    public void EatMeat(GameObject meat)
    {
        if (gameEnded) return;
        meat.SetActive(false);
    }

    void GameWin()
    {
        gameEnded = true;
        resultText.text = "You Win!";
        Invoke("NextScene", 2f); 
    }

    void GameFail()
    {
        gameEnded = true;
        resultText.text = "You Fail!";
    }

    void NextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
