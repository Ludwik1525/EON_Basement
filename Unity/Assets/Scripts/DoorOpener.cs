using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class DoorOpener : MonoBehaviour
{
    public bool isOpen = false;
    public AudioClip doorOpen;
    private AudioSource source;

    void Start()
    {
        source = this.GetComponent<AudioSource>();
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
                this.transform.GetChild(0).Rotate(0, 0, 90);
                isOpen = true;
                source.PlayOneShot(doorOpen);
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
