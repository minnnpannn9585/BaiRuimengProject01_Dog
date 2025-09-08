using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogClick14 : MonoBehaviour
{
    public GameObject dog2;

    private void OnMouseDown()   
    {
        transform.parent.GetComponent<Animator>().SetTrigger("Walk");
        StartCoroutine(EndAnimation());
    }

    IEnumerator EndAnimation()
    {
        yield return new WaitForSeconds(2f);
        dog2.AddComponent<PolygonCollider2D>();
    }
}
