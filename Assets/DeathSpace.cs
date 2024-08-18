using GameKit.Dependencies.Utilities;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathSpace : MonoBehaviour
{
    public ParticleSystem DeathDeath;

    private ParticleSystem newparticles;
    private Vector3 vv;
    private Quaternion vu;

    private void OnTriggerEnter(Collider collision)
    {
        Debug.Log("vdNo");
        if (collision.CompareTag("Player"))
        {
            Debug.Log("vd");
            vv = collision.transform.position;
            vu = collision.transform.rotation;
            newparticles = Instantiate(DeathDeath, vv, vu);
            newparticles.Play();
            collision.transform.SetPosition(false, collision.gameObject.GetComponent<FirstPersonController>().checkpoint.transform.position);
        }
    }
}
