using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Picture : MonoBehaviour
{
    public GameObject bigpicture;
    public GameObject dog;
    private void OnMouseDown()
    {
        bigpicture.SetActive(true);
        dog.AddComponent<PolygonCollider2D>();
    }
}
