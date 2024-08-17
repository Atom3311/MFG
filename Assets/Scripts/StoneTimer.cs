using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class StoneTimer : MonoBehaviour
{
    Rigidbody rb;
    public GameObject staroe;


    IEnumerator TimerStone()
    {
        yield return new WaitForSeconds(3f);
        staroe.SetActive(false);
        
        staroe.SetActive(true);
    }

    private void OnCollisionStay(Collision collision)
    {
        if(collision.collider.tag == "Player")
        {
            StartCoroutine(TimerStone());
        }
    }
}
