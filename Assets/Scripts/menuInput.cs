using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class menuInput : MonoBehaviour
{
    public TMP_InputField name;
    public GameObject play;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(name.text != "")
            play.SetActive(true);
        else
            play.SetActive(false);
    }
}
