using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class PalleteMove : MonoBehaviour
{
    public float Speed = 2;
    private bool Sostoynie = true;
    void Start()
    {
        StartCoroutine(FirstMove());
    }

    IEnumerator Move()
    {
        yield return new WaitForSeconds(3f);
        Sostoynie = false;
        StartCoroutine(ReverseMove());
    }
    IEnumerator ReverseMove()
    {
        yield return new WaitForSeconds(3f);
        Sostoynie = true;
        StartCoroutine(Move());
    }
    IEnumerator FirstMove()
    {
        yield return new WaitForSeconds(Random.Range(0.1f, 5));
        StartCoroutine(Move());
    }

    private void Update()
    {
        if (Sostoynie)
        {
            transform.position = new Vector3(transform.position.x + Speed * Time.deltaTime, transform.position.y, transform.position.z);
        }
        else
        {
            transform.position = new Vector3(transform.position.x + -Speed * Time.deltaTime, transform.position.y, transform.position.z);
        }
       
    }
}
