using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateOpen : MonoBehaviour
{
    PlayerMovement p;
    public GameObject Player;
    public GameObject gate;
    Animator gate_animator;
    AudioSource audioSrc;
    Story story;
    private void Start() {
        gate_animator = gate.GetComponent<Animator>();
        p = Player.GetComponent<PlayerMovement>();
        audioSrc = gate.GetComponent<AudioSource>();
        story = GetComponent<Story>();
    }
    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "Player" && p.checkPoint1 == true){
            gate_animator.SetBool("gate_open",true);
            audioSrc.Play();
            Debug.Log("Enter");
            story.SetText("Follow this route");
            
            
        }else{
            Debug.Log("First Clear CheckPoint 1");
        }
    }
    IEnumerator wait(){
        yield return new WaitForSeconds(3.0f);
    }
}
