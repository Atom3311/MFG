using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerTeleportation : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Teleport();
        }
    }
    void Teleport()
    {
        SceneManager.LoadScene("PA_AncientVillageDay", LoadSceneMode.Additive);
    }
}
