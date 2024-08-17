using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    public ParticleSystem DeathWater;
    public ParticleSystem DeathDeath;

    private ParticleSystem newparticles;
    private Vector3 vv;
    private Quaternion vu;

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.CompareTag("Player"))
        {
            vv = collision.transform.position;
            vu = collision.transform.rotation;
            Debug.Log("я умер");
            newparticles = Instantiate(DeathWater, vv, vu);
            newparticles.Play();
            newparticles = Instantiate(DeathDeath, vv, vu);
            newparticles.Play();

        }
    }
}
