using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meat : MonoBehaviour
{
    private void OnMouseDown()
    {
        FindObjectOfType<clickmeat>().AddNumber();
        Destroy(gameObject);
    }
}
