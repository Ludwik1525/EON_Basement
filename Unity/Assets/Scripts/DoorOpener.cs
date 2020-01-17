using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class DoorOpener : MonoBehaviour
{
    public bool isOpen = false;

    void Start()
    {
    }
    
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (!isOpen)
            {
                this.transform.GetChild(0).Rotate(0,0,90);
                isOpen = true;
            }
        }
    }
    
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            if (isOpen)
            {
                this.transform.GetChild(0).Rotate(0, 0, -90);
                isOpen = false;
            }
        }
    }


}
