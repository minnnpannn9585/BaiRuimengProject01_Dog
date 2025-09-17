using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogGoToCookie : MonoBehaviour
{
    public float speed;
    public Vector3 dir;
    public void DogGoTo(Vector3 position)
    {
        dir = position - transform.position;
        StartCoroutine(GoTo(position));
    }

    System.Collections.IEnumerator GoTo(Vector3 target)
    {
        while (Vector3.Distance(transform.position, target) > 0.05f)
        {
            transform.Translate(dir.normalized * Time.deltaTime * speed);
            yield return null;
        }
        
    }
}


