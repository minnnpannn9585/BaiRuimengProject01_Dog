using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickInccorect : MonoBehaviour
{
    public Text messageText;
    public GameObject wrong;

    private void OnMouseDown()
    {
            messageText.text = "Incorrect";

    }
}