using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class laver : MonoBehaviour
{
    public GameObject most;
    // Start is called before the first frame update
    void Start()
    {
        
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
                    if (most.activeSelf)
                    {
                        most.SetActive(false);
                    }
                    else
                    {
                        most.SetActive(true);
                    }




                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
