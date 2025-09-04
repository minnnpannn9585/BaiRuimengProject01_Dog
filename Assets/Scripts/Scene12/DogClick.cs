using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogClick : MonoBehaviour
{
    public GameObject photo;

    private void OnMouseDown()
    {
        transform.parent.GetComponent<Animator>().SetTrigger("walk");
        StartCoroutine(EndAnimation());
    }

    IEnumerator EndAnimation()
    {
        yield return new WaitForSeconds(2f);
        photo.AddComponent<PolygonCollider2D>();
    }
}
