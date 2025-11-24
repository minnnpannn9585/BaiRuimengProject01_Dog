using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WrongTextAutoDisappear : MonoBehaviour
{
    private float timer;
    public float disappearTime;
    void OnEnable()
    {
        timer = disappearTime;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            this.gameObject.SetActive(false);
        }
    }
}
