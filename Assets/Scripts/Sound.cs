using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {
        audioSrc = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.name == "Player"){
            audioSrc.Play();
        }
    }
}
