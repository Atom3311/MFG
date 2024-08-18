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
                Teleport(nob);
            }
        }
    }
    void Teleport(NetworkObject nob)
    {
        if (!nob.Owner.IsActive)
            return;

        SceneLoadData sld = new SceneLoadData("Demo_Scene_D");
        sld.MovedNetworkObjects = new NetworkObject[] { nob };
        sld.ReplaceScenes = ReplaceOption.All;
        InstanceFinder.SceneManager.LoadConnectionScenes(nob.Owner, sld);
        // SceneManager.LoadScene("", LoadSceneMode.Additive);

    }
}
