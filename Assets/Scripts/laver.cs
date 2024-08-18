using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using FishNet;
using FishNet.Broadcast;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Object.Synchronizing;
using FishNet.Transporting;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;

public class laver : NetworkBehaviour
{
    public GameObject most;

    public readonly SyncVar<bool> _enabled = new SyncVar<bool>();
    [ServerRpc] private void SetName(bool value) =>  _enabled.Value = value;

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

                        //    most.SetActive(!most.activeSelf);
                        //    SetName(!most.activeSelf);
                           _enabled.Value = !most.activeSelf;
                        }
                    }
                }
        
    }
    private void Update() {
        most.SetActive(_enabled.Value);
    }
}
