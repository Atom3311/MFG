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

    private readonly SyncVar<bool> _enabled = new SyncVar<bool>(new SyncTypeSettings(1f));
    
    private void Awake()
    {
        _enabled.OnChange += on_health;
    }

    //This is called when _health changes, for server and clients.
    private void on_health(bool prev, bool next, bool asServer)
    {
        /* Each callback for SyncVars must contain a parameter
        * for the previous value, the next value, and asServer.
        * The previous value will contain the value before the
        * change, while next contains the value after the change.
        * By the time the callback occurs the next value had
        * already been set to the field, eg: _health.
        * asServer indicates if the callback is occurring on the
        * server or on the client. Sometimes you may want to run
        * logic only on the server, or client. The asServer
        * allows you to make this distinction. */
        Debug.Log(next);
        most.SetActive(next);
    }

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
                           _enabled.Value = !most.activeSelf;
                        }
                    }
                }
        
    }
}
