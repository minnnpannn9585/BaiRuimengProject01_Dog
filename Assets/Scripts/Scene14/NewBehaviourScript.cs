using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour

{
    public bool isCorrect = false;
    public Text feedbackText;
    public float scaleSpeed = 8f;

    public Vector3 normalScale = Vector3.one * 0.93f;
    public Vector3 hoverScale = Vector3.one * 1.2f;
    private Vector3 targetScale;

    private void Start()
    {
        transform.localScale = normalScale;
        targetScale = normalScale;
    }

    private void Update()
    {
        transform.localScale = Vector3.Lerp(transform.localScale, targetScale, Time.deltaTime * scaleSpeed);
    }

    private void OnMouseEnter()
    {
        targetScale = hoverScale;
    }

    private void OnMouseExit()
    {
        targetScale = normalScale;
    }

    private void OnMouseDown()
    {
        if (isCorrect)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else
        {
            if (feedbackText != null)
            {
                feedbackText.text = "Incorrect";
                feedbackText.gameObject.SetActive(true);
                CancelInvoke(nameof(HideFeedback));
                Invoke(nameof(HideFeedback), 1.5f);
            }
        }
    }

    private void HideFeedback()
    {
        if (feedbackText != null)
            feedbackText.gameObject.SetActive(false);
    }
}

