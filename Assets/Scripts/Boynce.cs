using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boynce : MonoBehaviour
{
    [SerializeField]
    float buoyancy_force;
    Rigidbody rig;
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float y_pos = transform.position.y;
        if (y_pos < 5)
        {
            rig.AddForce(transform.up * buoyancy_force);
        }
    }
}
