using FishNet;
using FishNet.Managing.Scened;
using FishNet.Object;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerTeleportation : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            NetworkObject nob = other.GetComponent<NetworkObject>();
            if(nob != null) { 
                Teleport(nob, other.gameObject);
            }
        }
    }
    void Teleport(NetworkObject nob, GameObject player)
    {
        if (!nob.Owner.IsActive)
            return;

        SceneLoadData sld = new SceneLoadData("Demo_Scene_D");
        sld.MovedNetworkObjects = new NetworkObject[] { nob };
        InstanceFinder.SceneManager.LoadConnectionScenes(nob.Owner, sld);
        // SceneManager.LoadScene("", LoadSceneMode.Additive);
        player.transform.position = GameObject.FindWithTag("Four").transform.position;
        nob.transform.position = GameObject.FindWithTag("Four").transform.position;
        player.GetComponent<FirstPersonController>().checkpoint = GameObject.FindWithTag("Four");
        nob.GetComponent<FirstPersonController>().checkpoint = GameObject.FindWithTag("Four");

    }
}
