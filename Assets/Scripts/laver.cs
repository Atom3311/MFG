using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using FishNet;
using FishNet.Broadcast;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Transporting;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class laver : NetworkBehaviour
{
    public GameObject most;
    private void OnTriggerStay(Collider other)
    {
                if (Physics.Raycast(other.transform.position, other.transform.forward, out var hit, Mathf.Infinity))
                {
                    var obj = hit.collider.gameObject;
                    if (obj == this.gameObject)
                    {
                        Debug.Log("Press E");
                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            Debug.Log(most);    
                            Debug.Log(most.activeSelf);

                           most.SetActive(!most.activeSelf);
                        }
                    }
                }
        
    }
}
