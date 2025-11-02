using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meat : MonoBehaviour
{
    private TimeManager controller;

    void Start()
    {
        controller = FindObjectOfType<TimeManager>();
    }

    private void OnMouseDown()
    {
        controller.EatMeat(gameObject);
    }
}
