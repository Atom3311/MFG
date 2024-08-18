using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tp : MonoBehaviour
{
    private GameObject Player;
    void Start()
    {
        Player = GameObject.FindWithTag("Player");
        Player.GetComponent<FirstPersonController>().checkpoint = gameObject;
        Player.transform .position = gameObject.transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
