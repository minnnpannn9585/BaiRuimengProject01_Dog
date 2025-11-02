using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meat : MonoBehaviour
{
    private GameController controller;

    void Start()
    {
        controller = FindObjectOfType<GameController>();
    }

    private void OnMouseDown()
    {
        controller.EatMeat(gameObject);
    }
}
