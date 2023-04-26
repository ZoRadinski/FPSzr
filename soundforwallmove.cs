using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundforwallmove : MonoBehaviour
{
    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        // Check if the tag of the other Collider is "Player"
        if (other.tag == "Player")
        {
            audioSource.Play();
        }
    }
}
