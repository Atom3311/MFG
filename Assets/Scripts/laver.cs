using System.Collections;
using System.Collections.Generic;
using FishNet.Object;
using UnityEngine;
using UnityEngine.UI;

public class laver : NetworkBehaviour
{
    public GameObject most;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (base.IsOwner) {
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
                        RpcSendChat(!most.activeSelf);
                    }
                }
            }
        }
        
    }

    // Update is called once per frame
    [ServerRpc(RunLocally = true)]
    private void RpcSendChat(bool flag)
    {
        most.SetActive(flag);
        Debug.Log("server");
        Debug.Log(flag);
    }
}
