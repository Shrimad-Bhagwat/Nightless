using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coffinScript : MonoBehaviour
{
    // public GameObject[] coffins;
    // PlayerMovement pm;
    // public GameObject Player;
    // public GameObject coffin1;
    // public GameObject coffin2;
    // public GameObject coffin3;
    // public GameObject coffin4;
    // public GameObject coffin5;
    // int r;
    Animator anim;
    private void Start() {
        anim = GetComponent<Animator>();
        // pm = Player.GetComponent<PlayerMovement>();
        // r = pm.getRandom();
        

    }

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.name == "Player"){
            anim.SetBool("open_crate",true);
        }
    }

    private void OnTriggerExit(Collider other) {
            anim.SetBool("open_crate",false);
        
    }
}
